﻿//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MvcMovie.Models
//{
//    public interface ISPService
//    {

//        DataSet GetDataWithParameter<TParamOType>(TParamOType target, string storeProcedureName) where TParamOType : class;
//        DataSet GetDataWithoutParameter(string storeProcedureName);
//        DataSet GetDataBySqlCommand(string sqlString);
//        int GetSecurityModuleByControllerAction(string controller, string action);
//        DateTime GetBusinessDay();
//        int ExecuteStoredProcedure<TParamOType>(TParamOType target, string storedProcedure) where TParamOType : class;
//        DataSet GetBrokerEmployeeForRegister();
//    }
//    public class SPService : ISPService
//    {

//        public DataSet GetDataWithParameter<TParamOType>(TParamOType target, string storeProcedureName) where TParamOType : class
//        {
//            using (var gbData = new UERPDataAccess())
//            {
//                return gbData.GetDataOnDateset(storeProcedureName, target);
//            }
//        }

//        public DataSet GetDataWithoutParameter(string storeProcedureName)
//        {
//            using (var gbData = new UERPDataAccess())
//            {
//                return gbData.GetDataOnDatesetWithoutParam(storeProcedureName);
//            }
//        }

//        public DataSet GetDataBySqlCommand(string sql)
//        {
//            using (var gbData = new UERPDataAccess())
//            {
//                return gbData.GetDataOnDatesetBySqlCommand(sql);
//            }
//        }
//        public DateTime GetBusinessDay()
//        {
//            using (var gbData = new UERPDataAccess())
//            {
//                return DateTime.Parse(gbData.GetDataOnDatesetBySqlCommand("SELECT dbo.F_GET_BUSINESS_DAY()").Tables[0].Rows[0][0].ToString());
//            }
//        }

//        public int ExecuteStoredProcedure<TParamOType>(TParamOType target, string storedProcedure) where TParamOType : class
//        {
//            using (var gbData = new UERPDataAccess())
//            {
//                return gbData.ExecuteNonQuery(storedProcedure, target);
//            }
//        }

//        public int GetSecurityModuleByControllerAction(string controller, string action)
//        {
//            using (var gbData = new UERPDataAccess())
//            {
//                return int.Parse(gbData.GetDataOnDatesetBySqlCommand("SELECT AspNetSecurityModuleId FROM AspNetSecurityModule WHERE ControllerName='" + controller + "' AND ActionName='" + action + "'").Tables[0].Rows[0][0].ToString());
//            }
//        }

//        public DataSet GetBrokerEmployeeForRegister()
//        {
//            var storeProcedureName = "USP_GetBrokerEmployeeForRegister";
//            using (var gbData = new UERPDataAccess())
//            {
//                return gbData.GetDataOnDatesetWithoutParam(storeProcedureName);
//            }
//        }
//    }
//}
