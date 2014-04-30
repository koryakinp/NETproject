using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace groupAssignment
{
    public static class DataBase
    {
        const string strConnectionString =
            "DATA SOURCE =dilbert.humber.ca:1521/grok; USER ID =krkp0054; PASSWORD= oracle;";

        public static String getHashCodeFromDB(String username)
        {           
            String hashCode = "";
    
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = new OracleCommand("SELECT PASSWORD FROM USERS WHERE LOGIN = :LOGIN", oc);
                da.SelectCommand.Parameters.Add("LOGIN", OracleDbType.Varchar2).Value = username;
                oc.Open();
                OracleDataReader reader = da.SelectCommand.ExecuteReader();
                while (reader.Read())
                {
                    hashCode = reader.GetString(0);
                }
                oc.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);                
                return "";
            }

            return hashCode;
        }

        public static String getCountOfUsers(String username)
        {
            
            String result = "0";
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = new OracleCommand("SELECT COUNT(*) FROM USERS WHERE LOGIN = :LOGIN", oc);
                da.SelectCommand.Parameters.Add("LOGIN", OracleDbType.Varchar2).Value = username;
                oc.Open();
                OracleDataReader reader = da.SelectCommand.ExecuteReader();
                while (reader.Read())
                {
                    result = reader[0].ToString();
                }
                oc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }

            return result;
        }

        public static String getCountOfEmails(String email)
        {
            
            String result = "0";

            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.SelectCommand = new OracleCommand("SELECT COUNT(*) FROM USERS WHERE EMAIL = :EMAIL", oc);
                da.SelectCommand.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = email;
                oc.Open();
                OracleDataReader reader = da.SelectCommand.ExecuteReader();
                
                while (reader.Read())
                {
                    result = reader[0].ToString();
                }
                oc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }

            return result;
        }

        public static bool addNewUser(String username, String password, String name, String email)
        {
                     
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.InsertCommand = new OracleCommand("INSERT INTO USERS VALUES(:LOGIN, :PASSWORD, :NAME, :EMAIL)", oc);
                da.InsertCommand.Parameters.Add("LOGIN", OracleDbType.Varchar2).Value = username;
                da.InsertCommand.Parameters.Add("PASSWORD", OracleDbType.Varchar2).Value = password.GetHashCode().ToString();
                da.InsertCommand.Parameters.Add("NAME", OracleDbType.Varchar2).Value = name;
                da.InsertCommand.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = email;
                oc.Open();
                da.InsertCommand.ExecuteNonQuery();
                oc.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static User getUserByLogin(String login)
        {
            
            User user = null;
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.SelectCommand = new OracleCommand("SELECT * FROM USERS WHERE LOGIN = :LOGIN", oc);
                da.SelectCommand.Parameters.Add("LOGIN", OracleDbType.Varchar2).Value = login;
                oc.Open();
                OracleDataReader reader = da.SelectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                    oc.Close();
                    return user;
                }
                else
                {
                    oc.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static bool addNewAlert(String username, String symbol, double target)
        {

            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.InsertCommand = new OracleCommand("INSERT INTO USERALERTS VALUES(:USERNAME, :SYMBOL, :TARGET)", oc);
                da.InsertCommand.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = username;
                da.InsertCommand.Parameters.Add("SYMBOL", OracleDbType.Varchar2).Value = symbol;
                da.InsertCommand.Parameters.Add("TARGET", OracleDbType.Double).Value = target;
                oc.Open();
                da.InsertCommand.ExecuteNonQuery();
                oc.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool deleteAlert(String username, String symbol)
        {
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.DeleteCommand = new OracleCommand("DELETE FROM USERALERTS WHERE USERNAME = :USERNAME AND SYMBOL = :SYMBOL", oc);
                da.DeleteCommand.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = username;
                da.DeleteCommand.Parameters.Add("SYMBOL", OracleDbType.Varchar2).Value = symbol;
                oc.Open();
                da.DeleteCommand.ExecuteNonQuery();
                oc.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static ArrayList getUserAlerts(String username)
        {

            ArrayList result = new ArrayList();

            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.SelectCommand = new OracleCommand("SELECT * FROM USERALERTS WHERE USERNAME = :USERNAME", oc);
                da.SelectCommand.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = username;
                oc.Open();
                OracleDataReader reader = da.SelectCommand.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Alert(reader[1].ToString(), Convert.ToDouble(reader[2])));
                }
                oc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return result;
        }

        public static bool addUserQuotes(String username, String symbol)
        {
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.InsertCommand = new OracleCommand("INSERT INTO USERSYMBOLS VALUES(:USERNAME, :SYMBOL)", oc);
                da.InsertCommand.Parameters.Add("LOGIN", OracleDbType.Varchar2).Value = username;
                da.InsertCommand.Parameters.Add("SYMBOL", OracleDbType.Varchar2).Value = symbol;
                oc.Open();
                da.InsertCommand.ExecuteNonQuery();
                oc.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static ArrayList getUsersQuoteList(String username)
        {

            ArrayList result = new ArrayList();

            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.SelectCommand = new OracleCommand("SELECT SYMBOL FROM USERSYMBOLS WHERE USERNAME = :USERNAME", oc);
                da.SelectCommand.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = username;
                oc.Open();
                OracleDataReader reader = da.SelectCommand.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(reader[0].ToString());
                }
                oc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return result;
        }

        public static bool updatePassword(String username, String password)
        {

            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.UpdateCommand = new OracleCommand("UPDATE USERS SET PASSWORD = :PASSWORD WHERE LOGIN = :LOGIN", oc);
                da.UpdateCommand.Parameters.Add("PASSWORD", OracleDbType.Varchar2).Value = password.GetHashCode().ToString();
                da.UpdateCommand.Parameters.Add("LOGIN", OracleDbType.Varchar2).Value = username;
                oc.Open();
                da.UpdateCommand.ExecuteNonQuery();
                oc.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool deleteQuote(String username, String symbol)
        {
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.DeleteCommand = new OracleCommand("DELETE FROM USERSYMBOLS WHERE USERNAME = :USERNAME AND SYMBOL = :SYMBOL", oc);
                da.DeleteCommand.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = username;
                da.DeleteCommand.Parameters.Add("SYMBOL", OracleDbType.Varchar2).Value = symbol;
                oc.Open();
                da.DeleteCommand.ExecuteNonQuery();
                oc.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool addNewChart(ArrayList candles, String ChartName, String username)
        {
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();
                frm_chartManager frm = (frm_chartManager)Application.OpenForms["frm_chartManager"];
                
                int curPercent = 0;
                double value;
                oc.Open();
                da.InsertCommand = new OracleCommand("INSERT INTO CHARTS VALUES(:OPEN, :HIGH, :LOW, :CLOSE, :DATETIME, :SYMBOL, :USERNAME)", oc);
                for(int i = 0; i < candles.Count; i++)
                {
                    Candle candle = (Candle)candles[i];
                    da.InsertCommand.Parameters.Clear();
                    da.InsertCommand.Parameters.Add("OPEN", OracleDbType.Double).Value = candle.Open;
                    da.InsertCommand.Parameters.Add("HIGH", OracleDbType.Double).Value = candle.High;
                    da.InsertCommand.Parameters.Add("LOW", OracleDbType.Double).Value = candle.Low;
                    da.InsertCommand.Parameters.Add("CLOSE", OracleDbType.Double).Value = candle.Close;
                    da.InsertCommand.Parameters.Add("DATETIME", OracleDbType.TimeStamp).Value = candle.DateTime;
                    da.InsertCommand.Parameters.Add("SYMBOL", OracleDbType.Varchar2).Value = ChartName;
                    da.InsertCommand.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = User.curUsername;
                    da.InsertCommand.ExecuteNonQueryAsync();
                    value = ((double)i / (double)candles.Count) * 100;
                    if (value >= curPercent)
                    {
                        curPercent++;
                        frm.IncrementProgressBar();
                    }

                }
                oc.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static ArrayList getChartData(String Symbol)
        {
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.SelectCommand = new OracleCommand("SELECT * FROM CHARTS WHERE SYMBOL = :SYMBOL ORDER BY DATETIME ASC", oc);
                da.SelectCommand.Parameters.Add("SYMBOL", OracleDbType.Varchar2).Value = Symbol;
                oc.Open();
                OracleDataReader reader = da.SelectCommand.ExecuteReader();
                ArrayList chartData = new ArrayList();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        chartData.Add(new Candle(reader.GetDateTime(4), reader.GetDouble(1), reader.GetDouble(2), reader.GetDouble(0), reader.GetDouble(3)));
                    }
                    oc.Close();
                    return chartData;
                }
                else
                {
                    oc.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static ArrayList getUsersChartList(String username)
        {

            ArrayList result = new ArrayList();

            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.SelectCommand = new OracleCommand("SELECT DISTINCT SYMBOL FROM CHARTS WHERE USERNAME = :USERNAME OR USERNAME = 'DEFAULT'", oc);
                da.SelectCommand.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = username;
                //da.SelectCommand.Parameters.Add("DEFAULT", OracleDbType.Varchar2).Value = "DEFAULT";
                oc.Open();
                OracleDataReader reader = da.SelectCommand.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(reader[0].ToString());
                }
                oc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return result;
        }

        public static ArrayList getUsersImportedChartList(String username)
        {

            ArrayList result = new ArrayList();

            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.SelectCommand = new OracleCommand("SELECT DISTINCT SYMBOL FROM CHARTS WHERE USERNAME = :USERNAME", oc);
                da.SelectCommand.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = username;
                //da.SelectCommand.Parameters.Add("DEFAULT", OracleDbType.Varchar2).Value = "DEFAULT";
                oc.Open();
                OracleDataReader reader = da.SelectCommand.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(reader[0].ToString());
                }
                oc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return result;
        }

        public static ArrayList getDefaultChartList()
        {
            ArrayList result = new ArrayList();
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.SelectCommand = new OracleCommand("SELECT DISTINCT SYMBOL FROM CHARTS WHERE USERNAME = 'DEFAULT'", oc);
                oc.Open();
                OracleDataReader reader = da.SelectCommand.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(reader[0].ToString());
                }
                oc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return result;
        }

        public static bool deleteChartData(String symbol, String username)
        {
            try
            {
                OracleConnection oc = new OracleConnection(strConnectionString);
                OracleDataAdapter da = new OracleDataAdapter();

                da.DeleteCommand = new OracleCommand("DELETE FROM CHARTS WHERE SYMBOL = :SYMBOL AND USERNAME = :USERNAME", oc);
                da.DeleteCommand.Parameters.Add("SYMBOL", OracleDbType.Varchar2).Value = symbol;
                da.DeleteCommand.Parameters.Add("SYMBOL", OracleDbType.Varchar2).Value = username;
                oc.Open();
                da.DeleteCommand.ExecuteNonQuery();
                oc.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
