using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TrainWebApp.Data
{
    public class TrainRepository : ITrainRepository
    {
        private System.Data.IDbConnection db;

        public TrainRepository(string connString)
        {
            this.db = new System.Data.SqlClient.SqlConnection(connString);
        }

        public Train Add(Train train)
        {
            this.db.Insert(train);
            return train;

        }
    }
}