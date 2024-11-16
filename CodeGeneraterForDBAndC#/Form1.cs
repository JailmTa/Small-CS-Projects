using Guna.UI2.WinForms;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CodeGeneraterForDBAndC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        bool[] Cul = new bool[16];
        Guna2TextBox[] TextBoxessType = new Guna2TextBox[16];
        Guna2TextBox[] TextBoxessName = new Guna2TextBox[16];
        string Stutes = "ADD";
        private void MakeBool()
        {
            Cul[0] = false;
            for (int i = 1; i < 16; i++)
            {
                if (TextBoxessType[i].Name[4] == 't' && TextBoxessType[i].Text != "")
                {
                    Cul[i] = true;
                }
            }
        }
        string APIpar = "", ClsDTO = "", ClsConDTO = "", DTOPar = "", ClsCon = "", InnerPar = "", ApiHedare = " [ProducesResponseType(StatusCodes.Status200OK)]\n[ProducesResponseType(StatusCodes.Status400BadRequest)]\n[ProducesResponseType(StatusCodes.Status404NotFound)]\n";
        private string ConvertArrayToText(ref string Stetment, ref string StetmentADD, ref string DataLayerPar, ref string DataLayerBody, ref string CommondsLines)
        {
            string Paremetrs = "";

            AddTextBoxss();
            MakeBool();

            if (Stutes == "ADD")
            {
                for (int i = 1; i < Cul.Length; i++)
                {
                    if (Cul[i] && i == 1)
                    {
                        APIpar += "row." + TextBoxessName[i].Text + ",";
                        Paremetrs += "@" + (TextBoxessName[i].Text) + " " + (TextBoxessType[i].Text) + " output , \n";
                        DataLayerPar += (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text + " , ";
                        ClsDTO += "public " + (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text + " {get;set;}\n";
                        ClsConDTO += "this." + TextBoxessName[i].Text + " = " + TextBoxessName[i].Text + ";\n";
                        DTOPar += "this." + TextBoxessName[i].Text + " , ";
                        ClsCon += "this." + TextBoxessName[i].Text + " = " + tbtng.Text[0].ToString().ToUpper() + "DTO." + TextBoxessName[i].Text + ";\n";
                        CommondsLines += " SqlParameter output = new SqlParameter(" + "\"@" + (TextBoxessName[i].Text) + "\"," + "SqlDbType.Int );\n output.Direction = ParameterDirection.Output;\ncommand.Parameters.Add(output);\n";
                    }
                    else if (Cul[i] && Cul[i + 1] == true)
                    {
                        APIpar += "row." + TextBoxessName[i].Text + ",";
                        Paremetrs += "@" + (TextBoxessName[i].Text) + " " + (TextBoxessType[i].Text) + " , \n";
                        DataLayerPar += (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text + " , ";
                        ClsDTO += "public " + (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text + " {get;set;}\n";
                        ClsConDTO += "this." + TextBoxessName[i].Text + " = " + TextBoxessName[i].Text + ";\n";
                        Stetment += TextBoxessName[i].Text + " , ";
                        StetmentADD += "@" + TextBoxessName[i].Text + " , \n";
                        DTOPar += "this." + TextBoxessName[i].Text + " , ";
                        ClsCon += "this." + TextBoxessName[i].Text + " = " + tbtng.Text[0].ToString().ToUpper() + "DTO." + TextBoxessName[i].Text + ";\n";
                        DataLayerBody += "@" + (TextBoxessName[i].Text) + " = " + "@" + (TextBoxessName[i].Text) + " , ";
                        CommondsLines += "command.Parameters.AddWithValue(" + "\"@" + (TextBoxessName[i].Text) + "\",dto." + (TextBoxessName[i].Text) + ");\n";
                    }
                    else if (Cul[i] && Cul[i + 1] == false)
                    {
                        APIpar += "row." + TextBoxessName[i].Text;
                        ClsCon += "this." + TextBoxessName[i].Text + " = " + tbtng.Text[0].ToString().ToUpper() + "DTO." + TextBoxessName[i].Text + ";\n";
                        Paremetrs += "@" + (TextBoxessName[i].Text) + " " + (TextBoxessType[i].Text) + "  \n";
                        DataLayerPar += (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text;
                        ClsDTO += "public " + (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text + " {get;set;}\n";
                        ClsConDTO += "this." + TextBoxessName[i].Text + " = " + TextBoxessName[i].Text + ";\n";
                        Stetment += TextBoxessName[i].Text + "  \n";
                        StetmentADD += "@" + TextBoxessName[i].Text + "  \n";
                        DTOPar += "this." + TextBoxessName[i].Text;
                        DataLayerBody += "@" + (TextBoxessName[i].Text) + " = " + "@" + (TextBoxessName[i].Text) + " ";
                        CommondsLines += "command.Parameters.AddWithValue(" + "\"@" + (TextBoxessName[i].Text) + "\",dto." + (TextBoxessName[i].Text) + ");\n";
                    }
                }
            }
            else if (Stutes == "UPDATE")
            {
                for (int i = 1; i < Cul.Length; i++)
                {
                    if (Cul[i] && i == 1)
                    {
                        Paremetrs += "@" + (TextBoxessName[i].Text) + " " + (TextBoxessType[i].Text) + " , \n";
                        DataLayerPar += (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text + " , ";

                        DataLayerBody += "@" + (TextBoxessName[i].Text) + " = " + "@" + (TextBoxessName[i].Text) + " , ";
                        CommondsLines += "command.Parameters.AddWithValue(" + "\"@" + (TextBoxessName[i].Text) + "\"," + (TextBoxessName[i].Text) + ");\n";
                    }
                    else if (Cul[i] && Cul[i + 1] == true)
                    {
                        Paremetrs += "@" + (TextBoxessName[i].Text) + " " + (TextBoxessType[i].Text) + " , \n";
                        DataLayerPar += (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text + " , ";

                        Stetment += (TextBoxessName[i].Text) + "=@" + (TextBoxessName[i].Text) + " , \n";
                        DataLayerBody += "@" + (TextBoxessName[i].Text) + " = " + "@" + (TextBoxessName[i].Text) + " , ";
                        CommondsLines += "command.Parameters.AddWithValue(" + "\"@" + (TextBoxessName[i].Text) + "\",dto." + (TextBoxessName[i].Text) + ");\n";
                    }
                    else if (Cul[i] && Cul[i + 1] == false)
                    {
                        Paremetrs += "@" + (TextBoxessName[i].Text) + " " + (TextBoxessType[i].Text) + "   \n";
                        DataLayerPar += (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text;

                        Stetment += (TextBoxessName[i].Text) + "=@" + (TextBoxessName[i].Text) + "  \n";
                        DataLayerBody += "@" + (TextBoxessName[i].Text) + " = " + "@" + (TextBoxessName[i].Text) + "  ";
                        CommondsLines += "command.Parameters.AddWithValue(" + "\"@" + (TextBoxessName[i].Text) + "\",dto." + (TextBoxessName[i].Text) + ");\n";
                    }
                }
            }
            else if (Stutes == "DELETE")
            {
                Paremetrs += "@" + (TextBoxessName[1].Text) + " " + (TextBoxessType[1].Text) + "\n";
                DataLayerPar += (TextBoxessType[1].Text.Length > 0 && TextBoxessType[1].Text[0] == 'n' ? "string" : TextBoxessType[1].Text) + " " + TextBoxessName[1].Text;

                DataLayerBody += "@" + (TextBoxessName[1].Text) + " = " + "@" + (TextBoxessName[1].Text) + " ";
                CommondsLines += "command.Parameters.AddWithValue(" + "\"@" + (TextBoxessName[1].Text) + "\"," + (TextBoxessName[1].Text) + ");\n";
            }
            else
            {
                for (int i = 1; i < Cul.Length; i++)
                {
                    if (Cul[i] && i == 1)
                    {

                        Paremetrs += "@" + (TextBoxessName[i].Text) + " " + (TextBoxessType[i].Text) + " , \n";
                        DataLayerPar += (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text + " , ";
                        InnerPar += $" Convert.ToInt32(row[\"{TextBoxessName[i].Text}\"]),\n";
                        DataLayerBody += "@" + (TextBoxessName[i].Text) + " = " + "@" + (TextBoxessName[i].Text) + " ";
                        CommondsLines += "command.Parameters.AddWithValue(" + "\"@" + (TextBoxessName[i].Text) + "\",dto." + (TextBoxessName[i].Text) + ");\n";
                    }
                    else if (Cul[i] && Cul[i + 1] == true)
                    {
                        Paremetrs += "@" + (TextBoxessName[i].Text) + " " + (TextBoxessType[i].Text) + " output , \n";
                        DataLayerPar += (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text + " , ";
                        InnerPar += $" Convert.ToInt32(row[\"{TextBoxessName[i].Text}\"]),\n";
                        Stetment += "@" + (TextBoxessName[i].Text) + "=" + (TextBoxessName[i].Text) + " , \n";

                    }
                    else if (Cul[i] && Cul[i + 1] == false)
                    {
                        Paremetrs += "@" + (TextBoxessName[i].Text) + " " + (TextBoxessType[i].Text) + " output   \n";
                        DataLayerPar += (TextBoxessType[i].Text.Length > 0 && TextBoxessType[i].Text[0] == 'n' ? "string" : TextBoxessType[i].Text) + " " + TextBoxessName[i].Text;
                        InnerPar += $" Convert.ToInt32(row[\"{TextBoxessName[i].Text}\"])\n";
                        Stetment += "@" + (TextBoxessName[i].Text) + "=" + (TextBoxessName[i].Text) + "  \n";

                    }
                }
            }

            return Paremetrs;
        }

        private void AddTextBoxss()
        {
            TextBoxessType[0] = tbtng;
            TextBoxessName[0] = tbtng;
            ////////
            TextBoxessType[1] = tbc1t;
            TextBoxessType[2] = tbc2t;
            TextBoxessType[3] = tbc3t;
            TextBoxessType[4] = tbc4t;
            TextBoxessType[5] = tbc5t;
            TextBoxessType[6] = tbc6t;
            TextBoxessType[7] = tbc7t;
            TextBoxessType[8] = tbc8t;
            TextBoxessType[9] = tbc9t;
            TextBoxessType[10] = tbc10t;
            TextBoxessType[11] = tbc11t;
            TextBoxessType[12] = tbc12t;
            TextBoxessType[13] = tbc13t;
            TextBoxessType[14] = tbc14t;
            TextBoxessType[15] = tbc15t;
            ////////
            TextBoxessName[1] = tbc1n;
            TextBoxessName[2] = tbc2n;
            TextBoxessName[3] = tbc3n;
            TextBoxessName[4] = tbc4n;
            TextBoxessName[5] = tbc5n;
            TextBoxessName[6] = tbc6n;
            TextBoxessName[7] = tbc7n;
            TextBoxessName[8] = tbc8n;
            TextBoxessName[9] = tbc9n;
            TextBoxessName[10] = tbc10n;
            TextBoxessName[11] = tbc11n;
            TextBoxessName[12] = tbc12n;
            TextBoxessName[13] = tbc13n;
            TextBoxessName[14] = tbc14n;
            TextBoxessName[15] = tbc15n;
        }


        private void btnMakeCode_Click()
        {


            string Par = "", Ste = "", SteAdd = "", DataLayerPar = "", DataLayerBody = "", CommondsLines = "";
            Stutes = "ADD";
            Par = ConvertArrayToText(ref Ste, ref SteAdd, ref DataLayerPar, ref DataLayerBody, ref CommondsLines);
            string ClssDTO = "public class " + tbtng.Text + "DTO{\n";
            ClssDTO += ClsDTO;
            ClssDTO += "public " + tbtng.Text + "DTO(" + DataLayerPar + "){\n";
            ClssDTO += ClsConDTO;
            ClssDTO += "}\n}\n";

            string Clss = "public class " + tbtng.Text + "{\n";
            Clss += "public enum enMode{AddNew =0, UpDate=1};\n";
            Clss += "public enMode Mode=enMode.AddNew;\n" +
                "public " + tbtng.Text + "DTO " + tbtng.Text[0].ToString().ToUpper() + "DTO{\n" +
                "get{ return (new " + tbtng.Text + "DTO(" + DTOPar + "));}\n" +
                "}\n";
            Clss += ClsDTO;
            Clss += "public " + tbtng.Text + "(" + tbtng.Text + "DTO " + tbtng.Text[0].ToString().ToUpper() + "DTO , enMode  cMode = enMode.AddNew){\n";
            Clss += ClsCon;
            Clss += "Mode=cMode;\n}\n}";
            string add = "create procedure SP_Add" + tbtng.Text + "(\n" + Par + ")\n as\n begin\n insert into " + tbtng.Text + "(" + Ste + ")" + "\n values (" + SteAdd + ");\n set @" + TextBoxessName[1].Text + "= Scope_Identity(); \nend ;\n";
            string addcs = "public static int Add" + tbtng.Text + "(" + tbtng.Text + "DTO dto) {\n" +
                "using(SqlConnection connection = new SqlConnection(clsAccessSetting.Server())){\n" +
                                 "using( SqlCommand command = new SqlCommand(\"SP_Add" + tbtng.Text + "\", connection)){\n" +
                                 "command.CommandType = CommandType.StoredProcedure;\n" +
                                CommondsLines +
                                 "try {\n" +
                                 "connection.Open(); \n" +
                                 "command.ExecuteNonQuery();\n" +
                                 "return Convert.ToInt32(command.Parameters[\"@" + TextBoxessName[1].Text + "\"].Value);\n" +
                                 "}catch(Exception ex){\n" +
                                 "return 0;\n" +
                                 "}}}" +
                                 "return 0;\n}\n";
            string adddataAPI = " public static async Task<int> AddNew" + tbtng.Text + "(" + tbtng.Text + "DTO dto){\n" +
            "HttpClient client = new HttpClient();\n" +
            "client.BaseAddress = new Uri(\"https://localhost:7279/api/" + tbtng.Text + "\");\n" +
            "try\n{" +
            " var response = await client.PostAsJsonAsync(\"\", dto);\n" +
            "if(response.IsSuccessStatusCode){\n" +
            " var AddedObject =  await response.Content.ReadFromJsonAsync<" + tbtng.Text + "DTO>();\n" +
            "return AddedObject." + TextBoxessName[1].Text + ";\n}\n}" +
            "catch(Exception ex){\nreturn 0;}\nreturn 0;\n}\n";
            Stutes = "DELETE";
            Ste = ""; SteAdd = ""; DataLayerPar = ""; DataLayerBody = ""; CommondsLines = "";
            Par = ConvertArrayToText(ref Ste, ref SteAdd, ref DataLayerPar, ref DataLayerBody, ref CommondsLines);
            string delete = "create procedure SP_Delete" + tbtng.Text + "(\n" + Par + ")\n  as \nbegin \ndelete from " + tbtng.Text + " where @" + TextBoxessName[1].Text + "=" + TextBoxessName[1].Text + "\n end ;";
            string deletecs = "public static int Delete" + tbtng.Text + "(" + TextBoxessType[1].Text + " " + TextBoxessName[1].Text + ") {\n" +
                "using(SqlConnection connection = new SqlConnection(clsAccessSetting.Server())){\n" +
                " using(SqlCommand command = new SqlCommand(\"SP_Delete" + tbtng.Text + "\", connection)){\n" +
                  "command.CommandType = CommandType.StoredProcedure;\n" +
                                    CommondsLines +
                                 "try {\n" +
                                 "connection.Open();\n " +
                                 "int reader = command.ExecuteNonQuery(); \n" +
                                 "return reader;\n" +
                                 "}catch(Exception ex){\n" +
                                 "return 0;\n" +
                                 "}}}" +
                                 "return 0;\n}\n";
            string deletedataAPI = " public static async Task<int> Delete" + tbtng.Text + "(int ID){\n" +
            "HttpClient client = new HttpClient();\n" +
            "client.BaseAddress = new Uri(\"https://localhost:7279/api/" + tbtng.Text + "\");\n" +
            " var response = await client.DeleteAsync($\"{ID}\");" +
            "try\n{" +
            "  var requst = response.Content.ReadAsStringAsync();\n" +
            "if(response.IsSuccessStatusCode){\n" +
            "return 1;}\n" +
            "else{\n" +
            "return 0;}\n}\n" +
            "catch(Exception ex){\nreturn 0;}\n}\n";
            Stutes = "UPDATE";
            Ste = ""; SteAdd = ""; DataLayerPar = ""; DataLayerBody = ""; CommondsLines = "";
            Par = ConvertArrayToText(ref Ste, ref SteAdd, ref DataLayerPar, ref DataLayerBody, ref CommondsLines);
            string update = "create procedure SP_UpDate" + tbtng.Text + "(\n" + Par + ")\n as\n begin \nupdate " + tbtng.Text + " set " + Ste + " where @" + TextBoxessName[1].Text + "=" + TextBoxessName[1].Text + " end ;\n";
            string updatecs = "public static " + tbtng.Text + "DTO UpDate" + tbtng.Text + "(int ID" + tbtng.Text + "DTO dto)\n" +
                "{\n" +
                "using(SqlConnection connection = new SqlConnection(clsAccessSetting.Server())){\n" +
                 "using(SqlCommand command = new SqlCommand(\"SP_UpDate" + tbtng.Text + "\", connection)){\n" +
                   "command.CommandType = CommandType.StoredProcedure;\n" +
                                CommondsLines +
                                 "try {\n" +
                                 "connection.Open(); \n" +
                                 "dto." + TextBoxessName[1].Text + " = command.ExecuteNonQuery(); \n" +
                                 "return dto;\n" +
                                 "}catch(Exception ex){\n" +
                                 "return null;\n" +
                                 "}}}" +
                                 "return null;\n}\n";
            string updatedataAPI = " public static async Task<List<" + tbtng.Text + "DTO>> Find" + tbtng.Text + "(int ID){\n" +
            "HttpClient client = new HttpClient();\n" +
            "client.BaseAddress = new Uri(\"https://localhost:7279/api/" + tbtng.Text + "\");\n" +
            "try\n{" +
             " var requst = await client.GetAsync($\"{ID}\");" +
            tbtng.Text + "DTO response = await requst.Content.ReadFromJsonAsync<" + tbtng.Text + "DTO>();\n" +
            "if (response != null){\n" +
            "List<" + tbtng.Text + "DTO> list=new List<" + tbtng.Text + "DTO>();\n" +
            "list.Add(response);\n" +
            "return list;\n}" +
            "else{\nreturn null;\n}\n}" +
            "catch(Exception ex){\nreturn null;}\n}\n";


            Stutes = "FIND";
            Ste = ""; SteAdd = ""; DataLayerPar = ""; DataLayerBody = ""; CommondsLines = "";
            Par = ConvertArrayToText(ref Ste, ref SteAdd, ref DataLayerPar, ref DataLayerBody, ref CommondsLines);
            string find = "create procedure SP_Find" + tbtng.Text + "(\n@" + TextBoxessName[1].Text + " " + TextBoxessType[1].Text + "\n)\n as\n begin\n select * from " + tbtng.Text + " where @" + TextBoxessName[1].Text + "=" + TextBoxessName[1].Text + "\n end ;\n";
            string findcs = "public static " + tbtng.Text + "DTO Find" + tbtng.Text + "(" + TextBoxessType[1].Text + " " + TextBoxessName[1].Text + "){\n" +
              "using(SqlConnection connection = new SqlConnection(clsAccessSetting.Server())){\n" +
                 " using(SqlCommand command = new SqlCommand(\"SP_Find" + tbtng.Text + "\", connection)){\n" +
                   "command.CommandType = CommandType.StoredProcedure;\n" +
                                    CommondsLines +
                                 "try {\n" +
                                 "connection.Open(); \n" +
                                 "DataTable dt=new DataTable(); \n" +
                                 "using(SqlDataReader reader = command.ExecuteReader()){\n " +
                                 tbtng.Text + "DTO dto=null;" +
                                  "if (reader.HasRows)" +
                                     "{\n" +
                                           "dt.Load(reader);\n" +
                                           "foreach(DataRow row in dt.Rows){\n" +
                                           "dto=new " + tbtng.Text + "DTO(" +
                                       InnerPar +
                                       ");" +
                                       "\nbreak;\n}" +
                                       "return dto;\n}\n" +
                                       "else\n" +
                                       "{\n" +
                                           "return null;\n" +
                                       "}\n" +
                                         "}\n}catch(Exception ex){\n" +
                                 "return null;\n" +
                                 "}}return null;}" +
                                 "\n}\n";
            string finddataAPI = " public static async Task<" + tbtng.Text + "DTO> UpDate" + tbtng.Text + "(int ID,"+tbtng.Text+"DTO dto){\n" +
               "HttpClient client = new HttpClient();\n" +
               "client.BaseAddress = new Uri(\"https://localhost:7279/api/" + tbtng.Text + "\");\n" +
               "try\n{" +
                "  var Response = await client.PutAsJsonAsync($\"{ID}\", dto);" +
               " if (Response.IsSuccessStatusCode){\n" +
               "  var Person = await Response.Content.ReadFromJsonAsync<"+tbtng.Text+"DTO>();" +
               " if (Person != null)\n{\n" +
               "return Person;\n}" +
               "else{\nreturn null;\n}\n}\n}" +
               "catch(Exception ex){\nreturn null;}\nreturn null;\n}\n";
            string getdatatable = "create procedure SP_GetAll" + tbtng.Text + "\n as\n begin \nselect * from " + tbtng.Text + "\nend;\n";
            string getdatatablecs = "public static List<" + tbtng.Text + "DTO> GetAll" + tbtng.Text + "(){\n" +
                "using( SqlConnection connection = new SqlConnection(clsAccessSetting.Server())){\n" +
                 "using( SqlCommand command = new SqlCommand(\"SP_GetAll" + tbtng.Text + "\", connection)){\n" +
                   "command.CommandType = CommandType.StoredProcedure;\n" +
                   "List<" + tbtng.Text + "DTO> listdto=new List<" + tbtng.Text + "DTO>();\n" +
                                 "try {\n" +
                                 "connection.Open();\n" +
                                 "DataTable dt=new DataTable(); \n" +
                                 "using(SqlDataReader reader = command.ExecuteReader()){\n " +
                                  "if (reader.HasRows)\n" +
                                     "{\n" +
                                           "dt.Load(reader);\n" +
                                           "foreach(DataRow row in dt.Rows){\n" +
                                           tbtng.Text + "DTO dto=new " + tbtng.Text + "DTO(" +
                                       InnerPar +
                                       ");" +
                                       "\nlistdto.Add(dto);\n}" +
                                       "return listdto;\n}\n" +
                                       "else\n" +
                                       "{\n" +
                                           "return null;\n" +
                                       "}\n" +

                                 "}}\ncatch(Exception ex){\n" +
                                 "return null;\n" +
                                 "}}}return null;" +
                                 "}}";
            string getdataAPI = " public static async Task<List<" + tbtng.Text + "DTO>> GetAll()" + tbtng.Text + "{\n" +
                "HttpClient client = new HttpClient();\n" +
                "client.BaseAddress = new Uri(\"https://localhost:7279/api/" + tbtng.Text + "\");\n" +
                "try\n{" +
                " var response = await client.GetAsync(\"GetAll" + tbtng.Text + "\");\n" +
                "if(response.IsSuccessStatusCode){\n" +
                "var jsonResponse = await response.Content.ReadAsStringAsync();\n" +
                " var Table = JsonConvert.DeserializeObject<List<" + tbtng.Text + "DTO>>(jsonResponse);\n" +
                "List<" + tbtng.Text + "DTO> list=new List<" + tbtng.Text + "DTO>();\n" +
                "foreach(var row in Table){\n" +
                tbtng.Text + "DTO dto=new " + tbtng.Text + "DTO(" + APIpar + ");\n" +
                "list.Add(dto);\n}\n" +
                "return list;\n}" +
                "else{\nreturn null;\n}\n}" +
                "catch(Exception ex){\nreturn null;}\n}\n";


            string MainFolder = "c:/ProjectsMadeByCodeGen";
            Directory.CreateDirectory(MainFolder);

            string folderpath = MainFolder + "/" + tbtng.Text + "_Project";
            Directory.CreateDirectory(folderpath);

            StreamWriter streamWriter = new StreamWriter(folderpath + "/DataBase" + tbtng.Text + ".Sql");
            streamWriter.WriteLine(add);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(delete);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(update);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(find);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(getdatatable);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.Close();

            streamWriter = new StreamWriter(folderpath + "/API" + tbtng.Text + ".txt");
            streamWriter.WriteLine(adddataAPI);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(deletedataAPI);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(updatedataAPI);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(finddataAPI);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(getdataAPI);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.Close();

            streamWriter = new StreamWriter(folderpath + "/C_SharpProject" + tbtng.Text + ".txt");
            streamWriter.WriteLine(addcs);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(deletecs);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(updatecs);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(findcs);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(getdatatablecs);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.Close();

            streamWriter = new StreamWriter(folderpath + "/C_SharpProjectClasses" + tbtng.Text + ".txt");
            streamWriter.WriteLine(ClssDTO);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.WriteLine(Clss);
            streamWriter.WriteLine(Environment.NewLine);
            streamWriter.Close();
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            btnMakeCode_Click();
        }


    }
}
