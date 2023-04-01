using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPOI.ExcelReader
{
    
    public abstract class ExcelFileReader
    {
        protected IWorkbook workbook;
        protected DataFormatter dataFormatter;
        protected IFormulaEvaluator formulaEvaluator;

        //
        // Inicializamos el stream del archivo excel
        //
        protected void InitializeMembers(Stream excelFileStream)
        {
            this.workbook = WorkbookFactory.Create(excelFileStream);
            if (this.workbook != null)
            {
                this.dataFormatter = new DataFormatter(CultureInfo.InvariantCulture);
                this.formulaEvaluator = WorkbookFactory.CreateFormulaEvaluator(this.workbook);
            }
        }

        //
        // Obtenemos el valor formateado como un string de la celda específica
        //
        protected string GetFormattedValue(ICell cell)
        {
            string returnValue = string.Empty;
            if (cell != null)
            {
                try
                {
                    // Obtenemos el valor de la celda formateado
                    returnValue = this.dataFormatter.FormatCellValue(cell, this.formulaEvaluator);
                }
                catch
                {
                    if (cell.CellType == CellType.Formula)
                    {
                        switch (cell.CachedFormulaResultType)
                        {
                            case CellType.String:
                                returnValue = cell.StringCellValue;
                                cell.SetCellValue(cell.StringCellValue);
                                break;
                            case CellType.Numeric:
                                returnValue = dataFormatter.FormatRawCellContents(cell.NumericCellValue, 0, cell.CellStyle.GetDataFormatString());
                                cell.SetCellValue(cell.NumericCellValue);
                                break;
                            case CellType.Boolean:
                                returnValue = cell.BooleanCellValue.ToString();
                                cell.SetCellValue(cell.BooleanCellValue);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            return (returnValue ?? string.Empty).Trim();
        }

        //
        // Obtenemos el valor sin formato como un string de la celda específica
        //
        protected string GetUnformattedValue(ICell cell)
        {
            string returnValue = string.Empty;
            if (cell != null)
            {
                try
                {
                    // Obtenemos el valor de la celda evaluado
                    returnValue = (cell.CellType == CellType.Numeric || (cell.CellType == CellType.Formula && cell.CachedFormulaResultType == CellType.Numeric)) ?
                        formulaEvaluator.EvaluateInCell(cell).NumericCellValue.ToString() :
                        this.dataFormatter.FormatCellValue(cell, this.formulaEvaluator);
                }
                catch
                {
                    if (cell.CellType == CellType.Formula)
                    {
                        switch (cell.CachedFormulaResultType)
                        {
                            case CellType.String:
                                returnValue = cell.StringCellValue;
                                cell.SetCellValue(cell.StringCellValue);
                                break;
                            case CellType.Numeric:
                                returnValue = cell.NumericCellValue.ToString();
                                cell.SetCellValue(cell.NumericCellValue);
                                break;
                            case CellType.Boolean:
                                returnValue = cell.BooleanCellValue.ToString();
                                cell.SetCellValue(cell.BooleanCellValue);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            return (returnValue ?? string.Empty).Trim();
        }
    }
}
