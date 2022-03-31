using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class SqliteDataAccess
    {
        //ToDo: Make room for client database
        public static List<LayerModel> LoadLayers(string strDiscipline, string strGroup, string strFilter, bool Existing)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "Select LayerName, LayerDescription, LayerColor, LayerLinetype from LayerList";

                strQuery = strQuery + " WHERE LayerName LIKE '" + strDiscipline + "-" + strGroup + "%";

                if (strFilter == "TEXT" && strGroup != "TEXT") {strQuery = strQuery + "TEXT%";}

                if (strFilter == "SYMB") {strQuery = strQuery + "SYMB%";}

                if (Existing)
                {
                    strQuery = strQuery + "' AND LayerDescription LIKE '%existing%'";
                }
                else
                { 
                    strQuery = strQuery + "' AND NOT LayerDescription LIKE '%existing%'";                
                }

                strQuery = strQuery + " ORDER BY LayerName";

                var output = cnn.Query<LayerModel>(strQuery, new DynamicParameters());
                return output.ToList();

            }
        }

        public static List<LayerGroupModel> LoadLayerGroups(string DisciplineAssoc)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT GroupName, GroupAssoc FROM LayerGroups INNER JOIN LayerGroupbyDiscipline ON LayerGroupbyDiscipline.GroupId = LayerGroups.id LEFT JOIN LayerDisciplines ON LayerDisciplines.Id = LayerGroupbyDiscipline.DisciplineId WHERE LayerDisciplines.DisciplineAssoc = '" + DisciplineAssoc + "' ORDER BY GroupName";

                var output = cnn.Query<LayerGroupModel>(strQuery, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<LayerDisciplineModel> LoadLayerDisciplines()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "Select DisciplineName, DisciplineAssoc from LayerDisciplines";

                var output = cnn.Query<LayerDisciplineModel>(strQuery, new DynamicParameters());
                return output.ToList();

            }
        }

        private static string LoadConnectionString(string id = "Default") 
        { 
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
