using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.Model;

namespace BloodBank.Data.DataAccess
{
    public interface IReport
    {
        List<Report> GetReports(string filter);
        List<ReportBloodParameter> GetBloodParametersByReportId(int id);
        List<ReportViruses> GetReportVirusesByReportId(int id);
        void InsertReport(Report r, List<ReportBloodParameter> reportBloodParameters, List<ReportViruses> reportViruses);
       

    }
}
