using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlCreator
{
    public class TestDataServices
    {
        public DataTable GetPreOEDData(string connectionString)
        {
            var sql = @"SELECT TOP 1000 

                [t].[TransitID] AS [Id],
                [t].[PaymentGateID] AS [TerminalId],
                [g].[GateName] AS [TerminalName],
                [t].[EntranceDT] AS [TimeIn],
                [t].[ExitDT] AS [TimeOut],
                [t].[DueAmount] AS [Amount],
                [t].[DiscountAmount] AS [Discount]
                FROM [dbo].[Transits] [t]
                INNER JOIN [dbo].[Gates] [g] ON [t].[PaymentGateID] = [g].[GateID]
                ORDER BY [t].[TransitID] DESC";

            var items = SCObjects.LoadDataTable(sql, connectionString);
            return items;
        }
        public DataTable GetEODData(string connectionString)
        {
            var sql = @"SELECT [zr].[zReadingID] AS [Id],
                       [zr].[BeginDT],
                       [zr].[EndDT],
                       [g].[GateID] AS [TerminalId],
                       [g].[GateName] AS [TerminalName]
                FROM [dbo].[zReadings] [zr]
                    INNER JOIN [dbo].[Gates] [g]
                        ON [g].[GateID] = [zr].[GateID]
                ORDER BY [zr].[zReadingID]";

            var items = SCObjects.LoadDataTable(sql, connectionString);
            return items;
        }
    }
}
