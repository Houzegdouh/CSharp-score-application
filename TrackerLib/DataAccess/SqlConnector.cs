using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLib.Models;

namespace TrackerLib.DataAccess
{
 //   @PlaceNumber int,
	//@PlaceName nvarchar(50),
	//@PrizeAmount money,
 //   @PrizePercentage float,
	//@id int = 0 output
    class SqlConnector : IDataConnection
    {
        // TODO - Faire réellement enregistrer le prix dans la base de données
        /// <summary>
        /// Enregistre un prix dans la base de données
        /// </summary>
        /// <param name="model"> information sur le prix</param>
        /// <returns>information sur le prix, Id inclus</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                
                return model;
            };
        }
    }
}
