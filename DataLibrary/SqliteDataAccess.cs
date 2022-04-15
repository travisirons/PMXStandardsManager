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

        public static List<TextStyleModel> LoadTextStyles(bool Anno)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "Select * from TextStyles";
                if (Anno)
                {
                    strQuery = strQuery + " WHERE Annotative = 1";
                }
                else {
                    strQuery = strQuery + " WHERE Annotative = 0";
                }
                strQuery = strQuery + " ORDER BY Rank";

                var output = cnn.Query<TextStyleModel>(strQuery, new DynamicParameters());
                return output.ToList();

            }
        }

        public static List<DimensionStyleModel> LoadDimensionStyles(bool Anno, string Group)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "Select DIMSTYLE, DIMTXSTY, DIMANNO from DimensionStyles";
                if (Anno)
                {
                    strQuery = strQuery + " WHERE DIMANNO = 1";
                }
                else
                {
                    strQuery = strQuery + " WHERE DIMANNO = 0";
                }
                strQuery = strQuery + " AND DIMTXSTY LIKE '%" + Group + "%'";

                strQuery = strQuery + " ORDER BY DIMUNIT, DIMSCALE";
                var output = cnn.Query<DimensionStyleModel>(strQuery, new DynamicParameters());
                return output.ToList();

            }
        }

        public static List<LeaderStyleModel> LoadLeaderStyles(bool Anno, string Group)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "Select LeaderName, GroupId from MultileaderStyles";
                if (Anno)
                {
                    strQuery = strQuery + " WHERE Annotative = 1";
                }
                else
                {
                    strQuery = strQuery + " WHERE Annotative = 0";
                }
                strQuery = strQuery + " AND GroupId = " + Group;

                //strQuery = strQuery + " ORDER BY DIMUNIT, DIMSCALE";

                var output = cnn.Query<LeaderStyleModel>(strQuery, new DynamicParameters());
                return output.ToList();

            }
        }

        public static List<LinetypeModel> LoadLinetypes(string strFilter)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "Select * from Linetypes";

                if (strFilter == "_P")
                {
                    strQuery = strQuery + " WHERE linetype LIKE '%[_]P'";
                }
                else
                { 
                    strQuery = strQuery + " WHERE linetype NOT LIKE '%[_]P'";
                }

                var output = cnn.Query<LinetypeModel>(strQuery, new DynamicParameters());
                return output.ToList();

            }
        }

        public static List<LinetypeGroupModel> LoadLinetypeGroups()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT GroupName, GroupAssoc FROM LinetypeGroups";

                var output = cnn.Query<LinetypeGroupModel>(strQuery, new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default") 
        { 
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
