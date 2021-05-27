using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace MicorserviceBuilder
{
    public partial class frmmain : Form
    {
        string connectionString = "";
        DataSet TablesDS = new DataSet();
        public frmmain()
        {
            InitializeComponent();
        }

       

        private void btnConnect_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = ("Attempting to connect to database.");
            TablesDS.Clear();
             if (ChkIntegrated.Checked)
               connectionString =
                           "Data Source=" + txtServer.Text.Trim() + ";Initial Catalog=" + txtdatabase.Text.Trim() + ";"
                           + "Integrated Security=SSPI;Connection Timeout=1200";
            else 
             connectionString =
            "Data Source="+txtServer.Text.Trim()+";Initial Catalog=" + txtdatabase.Text.Trim() + ";"
            + "User ID="+txtusername.Text.Trim()+";Password="+txtPassword.Text.Trim();
            StringBuilder SQlCommands = new StringBuilder();
            SQlCommands.Append("SELECT TABLE_NAME,COLUMN_NAME,DATA_TYPE,IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS;");
            SQlCommands.Append("SELECT "+
                                 "   c.TABLE_NAME, c.COLUMN_NAME, c.DATA_TYPE, CONSTRAINT_TYPE " +
                                 " FROM  " +
                                 "   INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc  " +
                                 "    JOIN " +
                                 "   INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ccu " +
                                 "       ON tc.CONSTRAINT_NAME = ccu.Constraint_name " +
                                 "    join INFORMATION_SCHEMA.COLUMNS c on c.TABLE_NAME = tc.TABLE_NAME and ccu.COLUMN_NAME = c.COLUMN_NAME  " +
                                 " WHERE  " +
                                 "   tc.TABLE_NAME = c.TABLE_NAME AND  " +
                                 "   tc.CONSTRAINT_TYPE = 'Primary Key' ");

            using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create the SqlCommand object and identify it as a stored procedure.
            using (SqlCommand sqlCommand = new SqlCommand(SQlCommands.ToString(), connection))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandTimeout = 900000;
                // Add the order ID input parameter for the stored procedure.
                try
                {
                    // Open the connection.
                    connection.Open();
                    toolStripStatusLabel1.Text = ("Connection  established.");
                        // Run the command to execute the stored procedure.
                    Application.DoEvents();
                    SqlDataAdapter customerDA = new SqlDataAdapter();
                    customerDA.SelectCommand = sqlCommand;
                    toolStripStatusLabel1.Text = ("Getting data from Database.Please be Patient");
                    Application.DoEvents();
                    customerDA.Fill(TablesDS, "Tables");

                    toolStripStatusLabel1.Text = ("Connection and Database information retrieved. You can now build.");
                    pnlconnectbottem.Visible = true;
                    }
                catch (Exception ex)
                {
                        var err = ex.Message;
                        toolStripStatusLabel1.Text=("Connection could not be established.");
                }
                finally
                {
                    // Close connection.
                    connection.Close();
                }
            }
        }
        }

        private void btnFolderBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlconnectbottem.Visible = false;
            grpServerDetails.Visible = false;
            grpProjectname.Visible = false;
            loadingbox.Visible = true;
            tabcontrolmain.TabPages.Remove(tabKeyvault);
            tabcontrolmain.TabPages.Add(TabProjectdetails);

            string batfile  = Application.StartupPath + "\\CopyFiles\\Deploy.bat";
            string settingsfile= Application.StartupPath + "\\CopyFiles\\local.settings.json";
            string Dockerignorefile = Application.StartupPath + "\\CopyFiles\\.dockerignore";
            string ReturnData = Application.StartupPath + "\\CopyFiles\\ReturnData.cs";
            string CrudEnum = Application.StartupPath + "\\CopyFiles\\CrudEnum.cs";
            string FillReqObject = Application.StartupPath + "\\CopyFiles\\FillReqObject.cs";
            string ReqObject = Application.StartupPath + "\\CopyFiles\\ReqObject.cs";
            string keyvaultclass = Application.StartupPath + "\\CopyFiles\\Keyvault.cs";




            string Dockerfile = Application.StartupPath + "\\Templates\\Dockerfile";
      

            toolStripStatusLabel1.Text = "Preparing Project Files, Please be Patient.";

            // build solution creator
            if (txtFolder.Text!= "") 
            {
                if (!System.IO.Directory.Exists(txtFolder.Text))
                    System.IO.Directory.CreateDirectory(txtFolder.Text);

 
            
                System.IO.File.Copy(batfile, txtFolder.Text+"\\Deploy.bat", true);
                
                var execpath = txtFolder.Text + "\\Deploy.bat";
                string text = File.ReadAllText(execpath);
                text = text.Replace("@@ProjectName", txtProjectName.Text.Trim());
                text = text.Replace("@@Path", txtFolder.Text.Trim());
                text = text.Replace("@@Server", txtServer.Text.Trim());
                text = text.Replace("@@DB", txtdatabase.Text.Trim());
                text = text.Replace("@@User", txtusername.Text.Trim());
                text = text.Replace("@@Password", txtPassword.Text.Trim());
                File.WriteAllText(execpath, text);


              
                try
                {

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C " + @""""+execpath+@"""";
                    process.StartInfo = startInfo;
                    process.Start();

                    while (!File.Exists(txtFolder.Text.Trim() + "\\Readme.txt"))
                    {
                      
                        Application.DoEvents();
                        toolStripStatusLabel1.Text = "Creating Data Access Layer and linking Projects.";
                    }
                    toolStripStatusLabel1.Text = "Creating Function Crud Functions.";


                    File.Delete(txtFolder.Text + "\\Deploy.bat");
                    System.IO.File.Copy(settingsfile, txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\local.settings.json", true);
                    System.IO.File.Copy(Dockerignorefile, txtFolder.Text +  "\\.dockerignore", true);
                    System.IO.File.Copy(Dockerfile, txtFolder.Text + "\\Dockerfile", true);

                    //classes Returndata 20201109 fix 

                    if (!Directory.Exists(txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes"))
                        Directory.CreateDirectory(txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes");

                    //System.IO.File.Copy(ReturnData, txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\ReturnData.cs", true);
                    //System.IO.File.Copy(CrudEnum, txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\CrudEnum.cs", true);
                    //System.IO.File.Copy(FillReqObject, txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\FillReqObject.cs", true);
                    //System.IO.File.Copy(ReqObject, txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\ReqObject.cs", true);

                    string ReturnDatasettings = File.ReadAllText(ReturnData);
                    ReturnDatasettings = ReturnDatasettings.Replace("@@ProjectName", txtProjectName.Text.Trim());
                    File.WriteAllText(txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\ReturnData.cs", ReturnDatasettings);

                    string CrudEnumsettings = File.ReadAllText(CrudEnum);
                    CrudEnumsettings = CrudEnumsettings.Replace("@@ProjectName", txtProjectName.Text.Trim());
                    File.WriteAllText(txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\CrudEnum.cs", CrudEnumsettings);

                    string FillReqObjectsettings = File.ReadAllText(FillReqObject);
                    FillReqObjectsettings = FillReqObjectsettings.Replace("@@ProjectName", txtProjectName.Text.Trim());
                    File.WriteAllText(txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\FillReqObject.cs", FillReqObjectsettings);

                    string ReqObjectsettings = File.ReadAllText(ReqObject);
                    ReqObjectsettings = ReqObjectsettings.Replace("@@ProjectName", txtProjectName.Text.Trim());
                    File.WriteAllText(txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\ReqObject.cs", ReqObjectsettings);

                    

                    string Dockersettings = File.ReadAllText(txtFolder.Text + "\\Dockerfile");
                    Dockersettings = Dockersettings.Replace("@@ProjectName", txtProjectName.Text.Trim());
                    Dockersettings = Dockersettings.Replace("@@Path", txtFolder.Text.Trim());
                    if (chkKeyvault.Checked)
                    {
                        Dockersettings = Dockersettings.Replace("@@KeyvaultSecret", edtKeyvaultSecret.Text.Trim());
                        Dockersettings = Dockersettings.Replace("@@KeyvaultUri", edtKeyvaultUrl.Text.Trim());
                        Dockersettings = Dockersettings.Replace("@@AZURE_CLIENT_ID", edtClientID.Text.Trim());
                        Dockersettings = Dockersettings.Replace("@@AZURE_TENANT_ID", edtTenantID.Text.Trim());
                        Dockersettings = Dockersettings.Replace("@@AZURE_CLIENT_PWD", edtClientPWD.Text.Trim());
                    }
                    else
                    {
                        Dockersettings = Dockersettings.Replace("@@Server", txtServer.Text.Trim());
                        Dockersettings = Dockersettings.Replace("@@DB", txtdatabase.Text.Trim());
                        Dockersettings = Dockersettings.Replace("@@User", txtusername.Text.Trim());
                        Dockersettings = Dockersettings.Replace("@@Password", txtPassword.Text.Trim());

                    }


                    File.WriteAllText(txtFolder.Text  + "\\Dockerfile", Dockersettings);

                    File.Copy(Application.StartupPath + "\\CopyFiles\\Keyvault.cs", txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\Keyvault.cs");

                    var KeyvaultClass = File.ReadAllText(txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\Keyvault.cs");
                    KeyvaultClass = KeyvaultClass.Replace("@@ProjectName", txtProjectName.Text.Trim());
                    File.WriteAllText(txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\Classes\\Keyvault.cs", KeyvaultClass);

                    string textsettings = File.ReadAllText(txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\local.settings.json");
                    textsettings = textsettings.Replace("@@ProjectName", txtProjectName.Text.Trim());
                    textsettings = textsettings.Replace("@@Path", txtFolder.Text.Trim());
                  
                    if( chkKeyvault.Checked)
                    {
                        textsettings = textsettings.Replace("@@KeyvaultSecret", edtKeyvaultSecret.Text.Trim());
                        textsettings = textsettings.Replace("@@KeyvaultUri", edtKeyvaultUrl.Text.Trim());
                        textsettings = textsettings.Replace("@@AZURE_CLIENT_ID", edtClientID.Text.Trim());
                        textsettings = textsettings.Replace("@@AZURE_TENANT_ID", edtTenantID.Text.Trim());
                        textsettings = textsettings.Replace("@@AZURE_CLIENT_PWD", edtClientPWD.Text.Trim());
                    }
                    else
                    {
                        textsettings = textsettings.Replace("@@Server", txtServer.Text.Trim());
                        textsettings = textsettings.Replace("@@DB", txtdatabase.Text.Trim());
                        textsettings = textsettings.Replace("@@User", txtusername.Text.Trim());
                        textsettings = textsettings.Replace("@@Password", txtPassword.Text.Trim());
                    }
                    File.WriteAllText(txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\local.settings.json", textsettings);
                    
                    BuildClasses(TablesDS);
                }
                catch (Exception ex)
                {
                    var error = ex.Message;
                    MessageBox.Show(ex.Message);
                    toolStripStatusLabel1.Text = "An Error occurred during project creation";
                    Console.WriteLine(ex.StackTrace.ToString());
                }
                finally
                {
                    grpServerDetails.Visible = true;
                    grpProjectname.Visible = true;
                    pnlconnectbottem.Visible = true;
                    loadingbox.Visible = false;
                    toolStripStatusLabel1.Text = "Project Complete";
                    tabcontrolmain.TabPages.Add(TabDocker);
                    txtDockerCmds.Text = "docker build -t fn" + txtProjectName.Text.Trim().ToLower() + " -f Dockerfile .";
                    tabcontrolmain.TabPages.Remove(TabProjectdetails);
                }
            }

        }
        private void BuildClasses(DataSet ds)
        {
            var FuncClassDir = txtFolder.Text.Trim() + "\\" + txtProjectName.Text.Trim() + "\\Classes";
            var FuncDir = txtFolder.Text.Trim() + "\\" + txtProjectName.Text.Trim() + "\\Functions";
            var BaseFunc = Application.StartupPath + "\\Templates\\FunctionBase.txt";
            var BaseFuncperid = Application.StartupPath + "\\Templates\\FunctionBasePerID.txt";
            var SwaggerFunctions = Application.StartupPath + "\\Templates\\SwaggerFunctions.cs";
            var SwaggerStartup = Application.StartupPath + "\\Templates\\SwashBuckleStartup.cs";
            var startupfile = Application.StartupPath + "\\Templates\\Startup.cs";
            



            var BaseFuncCrud = Application.StartupPath + "\\Templates\\FunctionCrud.txt";

            try
            {
                foreach (DataRow row in ds.Tables[1].Rows)
                {

                    var TableName   = row["TABLE_NAME"].ToString();
                    var Pk          = row["COLUMN_NAME"].ToString();
                    if (TableName.ToLower() != "sysdiagrams")
                    {


                        if (!System.IO.Directory.Exists(FuncClassDir))
                            System.IO.Directory.CreateDirectory(FuncClassDir);

                        if (!System.IO.Directory.Exists(FuncDir))
                            System.IO.Directory.CreateDirectory(FuncDir);

                        var basefuncfile = FuncDir + "\\" + TableName.Trim() + ".cs";
                        var basefuncfilePerid = FuncDir + "\\" + TableName.Trim() + "ById.cs";

                        var Crudfuncfile = FuncClassDir + "\\" + TableName.Trim() + "GetFunctions.cs";
            

                        System.IO.File.Copy(BaseFunc, basefuncfile, true);
                        System.IO.File.Copy(BaseFuncCrud, Crudfuncfile, true);
                        System.IO.File.Copy(BaseFuncperid, basefuncfilePerid, true);

                        System.IO.File.Copy(SwaggerFunctions, FuncDir + "\\SwaggerFunctions.cs", true);
                        System.IO.File.Copy(SwaggerStartup, txtFolder.Text.Trim() + "\\" + txtProjectName.Text.Trim()  + "\\SwashBuckleStartup.cs", true);

                        System.IO.File.Copy(startupfile, txtFolder.Text.Trim() + "\\" + txtProjectName.Text.Trim() + "\\Startup.cs", true);

                        //Startup.cs
                        string Pretextst = File.ReadAllText(txtFolder.Text.Trim() + "\\" + txtProjectName.Text.Trim() + "\\Startup.cs");
                        StringBuilder connstring = new StringBuilder();
                        //write keyvault here 
                        if (chkKeyvault.Checked)
                        {
                            connstring.Clear();
                            connstring.Append(@"string connectionString = ""Connection Not Made"";" + System.Environment.NewLine);
                            connstring.Append("if (Keyvault.GetConnectionString(ref connectionString))" + System.Environment.NewLine);
                            connstring.Append("{" + System.Environment.NewLine);
                            connstring.Append("builder.Services.AddDbContext<@@DBContext>(options => options.UseSqlServer(connectionString).UseLazyLoadingProxies());" + System.Environment.NewLine);
                            connstring.Append("}" + System.Environment.NewLine);
                            Pretextst = Pretextst.Replace("@@ifKeyvault", connstring.ToString());
                        }
                        else
                        {
                            connstring.Clear();
                            connstring.Append(@"var connectionString = Environment.GetEnvironmentVariable(""SqlConnectionString"");" + System.Environment.NewLine);
                            connstring.Append(@"builder.Services.AddDbContext<@@DBContext>(options => options.UseSqlServer(connectionString).UseLazyLoadingProxies()); }" + System.Environment.NewLine);
                            Pretextst = Pretextst.Replace("@@ifKeyvault", connstring.ToString());
                        }
                        File.WriteAllText(txtFolder.Text.Trim() + "\\" + txtProjectName.Text.Trim() + "\\Startup.cs", Pretextst);
                        //
                        string textst = File.ReadAllText(txtFolder.Text.Trim() + "\\" + txtProjectName.Text.Trim() + "\\Startup.cs");
                        textst = textst.Replace("@@ProjectName", txtProjectName.Text.Trim());
                        textst = textst.Replace("@@DB", txtdatabase.Text.Trim());
                        
                   
                        
                        File.WriteAllText(txtFolder.Text.Trim() + "\\" + txtProjectName.Text.Trim() + "\\Startup.cs", textst);

                        string textsf = File.ReadAllText(FuncDir + "\\SwaggerFunctions.cs");
                        textsf = textsf.Replace("@@ProjectName", txtProjectName.Text.Trim());
                        textsf = textsf.Replace("@@DB", txtProjectName.Text.Trim());

                        File.WriteAllText(FuncDir + "\\SwaggerFunctions.cs", textsf);

                        string textsw = File.ReadAllText(txtFolder.Text.Trim() + "\\" + txtProjectName.Text.Trim() + "\\SwashBuckleStartup.cs");
                        textsw = textsw.Replace("@@ProjectName", txtProjectName.Text.Trim());
                        File.WriteAllText(txtFolder.Text.Trim() + "\\" + txtProjectName.Text.Trim() + "\\SwashBuckleStartup.cs", textsw);

                        //var SwaggerFunctions = Application.StartupPath + "\\Templates\\SwaggerFunctions.cs";
                        //var SwaggerStartup = Application.StartupPath + "\\Templates\\SwashBuckleStartup.cs";

                        StringBuilder ColumnLoop = new StringBuilder();
                        StringBuilder ColumnLoop_NoPK = new StringBuilder();
                        StringBuilder ColumnLoop_entity = new StringBuilder();

                        //  DataRow[] rows = ds.Tables[0].Select("TableName = "+);

                        var results = from myRow in ds.Tables[0].AsEnumerable()
                                      where myRow.Field<string>("TABLE_NAME") == TableName.Trim()
                                      where myRow.Field<string>("TABLE_NAME").ToLower() != "sysdiagrams"
                                      select myRow;

                       
                    foreach (var rowvalue in results)
                    {

                            // check in ef file 

                            string colname = "";
                            string[] colwords = rowvalue["COLUMN_NAME"].ToString().Split('_');

                            foreach (var word in colwords)
                            {
                                if (word != colwords[colwords.Length - 1])
                                    colname += char.ToUpper(word[0]) + word.Substring(1).ToLower();
                                else
                                {

                                    colname += char.ToUpper(word[0]) + word.Substring(1);
                                }
                            }
                            if (File.Exists(txtFolder.Text.Trim() + "\\Dal\\Models\\" + TableName.Replace("_", "") + ".cs"))
                            {

                            
                            foreach (var line in File.ReadAllLines(txtFolder.Text.Trim() + "\\Dal\\Models\\" + TableName.Replace("_", "") + ".cs"))
                            {
                               
                                try
                                {
                                    if (line.ToUpper().Contains(colname.ToUpper()) && line.ToUpper().Contains("{ GET; SET; }"))
                                    {
                                        var colvalue = line.Trim().Split(' ');
                                        if (colvalue[1].Trim().ToUpper() != "VIRTUAL")
                                        {
                                            if ((colvalue[2].Trim().ToUpper() == colname.ToUpper()) || (colvalue[2].Trim().ToUpper() == colname.ToUpper().Replace("_", "")))
                                                colname = colvalue[2];
                                            if ((colvalue[2].Trim().ToUpper() == Pk.ToUpper()) || (colvalue[2].Trim().ToUpper() == Pk.ToUpper().Replace("_", "")))
                                                Pk = colvalue[2];
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    string err = ex.Message;
                                    continue;
                                }

                            }
                            }


                            ColumnLoop.Append(colname + " = dataObj." + colname + "," + Environment.NewLine);
                            ColumnLoop_entity.Append(colname + " = entity." + colname + "," + Environment.NewLine);

                    }

                    var resultsnoPk = from myRow in ds.Tables[0].AsEnumerable()
                                  where myRow.Field<string>("TABLE_NAME") == TableName.Trim()
                                  where myRow.Field<string>("COLUMN_NAME").ToUpper() != Pk.Trim().ToUpper()
                                  where myRow.Field<string>("TABLE_NAME").ToLower() != "sysdiagrams"
                                      select myRow;

                    foreach (var rowvalue in resultsnoPk)
                    {
                            string colname = "";
                            string[] colwords = rowvalue["COLUMN_NAME"].ToString().Split('_');

                            foreach (var word in colwords)
                            {
                                if (word != colwords[colwords.Length - 1])
                                    colname += char.ToUpper(word[0]) + word.Substring(1).ToLower();
                                else
                                {

                                    colname += char.ToUpper(word[0]) + word.Substring(1);
                                }
                            }
                            if (File.Exists(txtFolder.Text.Trim() + "\\Dal\\Models\\" + TableName.Replace("_", "") + ".cs"))
                            {

                                foreach (var line in File.ReadAllLines(txtFolder.Text.Trim() + "\\Dal\\Models\\" + TableName.Replace("_", "") + ".cs"))
                                {
                                    try
                                    {
                                        if (line.ToUpper().Contains(colname.ToUpper()) && line.ToUpper().Contains("{ GET; SET; }"))
                                        {
                                            var colvalue = line.Trim().Split(' ');
                                            if (colvalue[1].Trim().ToUpper() != "VIRTUAL")
                                            {
                                                if ((colvalue[2].Trim().ToUpper() == colname.ToUpper()) || (colvalue[2].Trim().ToUpper() == colname.ToUpper().Replace("_", "")))
                                                    colname = colvalue[2];
                                                if ((colvalue[2].Trim().ToUpper() == Pk.ToUpper()) || (colvalue[2].Trim().ToUpper() == Pk.ToUpper().Replace("_", "")))
                                                    Pk = colvalue[2];
                                            }

                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        string err = ex.Message;
                                        continue;
                                    }


                                }
                            }
                            ColumnLoop_NoPK.Append(colname + " = dataObj." + colname + ","+ Environment.NewLine);

                    }

                    //Crud Function

                    
                    string[] words = TableName.Trim().Split('_');
                    string newtablename = "";
                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                        try
                        {
                            foreach (var word in words)
                            {
                                if (word != words[words.Length - 1])
                                    newtablename += char.ToUpper(word[0]) + word.Substring(1).ToLower();
                                else
                                    newtablename += char.ToUpper(word[0]) + word.Substring(1);

                            }
                            //ef models check names 2021/02/13
                            System.IO.FileInfo[] files = null;
                            System.IO.DirectoryInfo directoryInfo = new DirectoryInfo(txtFolder.Text.Trim() + "\\Dal\\Models\\");
                            files = directoryInfo.GetFiles("*.*");
                            foreach (System.IO.FileInfo File in files)
                            {
                                if (newtablename.ToUpper() == File.Name.Replace(".cs", "").ToUpper())
                                {
                                    if (newtablename != File.Name.Replace(".cs", ""))
                                    {
                                        newtablename = File.Name.Replace(".cs", "");
                                    }
                                }

                            }
                            //ef models check names 2021/02/13

                        }
                        catch (Exception)
                        {
                            newtablename = TableName.Trim();
                            continue;
                        }
                   


                    string Crudtext = File.ReadAllText(Crudfuncfile);
                    Crudtext = Crudtext.Replace("@@ProjectName", txtProjectName.Text.Trim());
                    Crudtext = Crudtext.Replace("@@TableName", TableName.Trim());
                    Crudtext = Crudtext.Replace("@@PrimaryKey", Pk.Trim());
                    Crudtext = Crudtext.Replace("@@DB", txtdatabase.Text.Trim());
                    Crudtext = Crudtext.Replace("@@ContextTable", newtablename.Trim());
                    Crudtext = Crudtext.Replace("@@ColumnLoop", ColumnLoop.ToString().Trim());
                    Crudtext = Crudtext.Replace("@@NoPKCol", ColumnLoop_NoPK.ToString().Trim());
                    Crudtext = Crudtext.Replace("@@EntityCol", ColumnLoop_entity.ToString().Trim());
                    // all Id incorrect values as per enity 
                    Crudtext = Crudtext.Replace("ID", "Id");
                    File.WriteAllText(Crudfuncfile, Crudtext);

                        //base function
                        string text = File.ReadAllText(basefuncfile);
                        text = text.Replace("@@ProjectName", txtProjectName.Text.Trim());
                        text = text.Replace("@@TableName", TableName.Trim());
                        text = text.Replace("@@PrimaryKey", Pk.Trim());
                        text = text.Replace("@@DB", txtdatabase.Text.Trim());
                        text = text.Replace("@@ContextTable", newtablename.Trim());
                        // all Id incorrect values as per enity 
                        text = text.Replace("ID", "Id");
                        File.WriteAllText(basefuncfile, text);

                        string textperid = File.ReadAllText(basefuncfilePerid);
                        textperid = textperid.Replace("@@ProjectName", txtProjectName.Text.Trim());
                        textperid = textperid.Replace("@@TableName", TableName.Trim());
                        textperid = textperid.Replace("@@PrimaryKey", Pk.Trim());
                        textperid = textperid.Replace("@@DB", txtdatabase.Text.Trim());
                        textperid = textperid.Replace("@@ContextTable", newtablename.Trim());
                        // all Id incorrect values as per enity 
                        textperid = textperid.Replace("ID", "Id");
                        File.WriteAllText(basefuncfilePerid, textperid);

                    }
                }
            }
            catch (Exception ex )
            {
                var error = ex.Message;
                throw;
            }
        }



        string FormatOutput(string message)
        {
            return string.Format("[ {0} ] : {1}",
                DateTime.Now.ToShortTimeString(),
                message);
        }

        void HandleDBServerOutput(object sender, DataReceivedEventArgs e)
        {
            string err = "";
            this.BeginInvoke(new MethodInvoker(() =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                    err +=FormatOutput(e.Data);
            }));
        }

        private void btnFolderBrowse_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            pnlconnectbottem.Visible = true;
        }

        private void btnBuild_Click_1(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtProjectName_Resize(object sender, EventArgs e)
        {

        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            tabcontrolmain.TabPages.Remove(TabDocker);
            tabcontrolmain.TabPages.Remove(tabKeyvault);
            tabcontrolmain.TabPages.Remove(tabPipeline);
        }

        private void txtDockerCmds_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNewService_Click(object sender, EventArgs e)
        {
            tabcontrolmain.TabPages.Add(TabProjectdetails);
            txtDockerCmds.Text = "";
            tabcontrolmain.TabPages.Remove(TabDocker);
        }

        private void ChkIntegrated_CheckedChanged(object sender, EventArgs e)
        {

            txtPassword.Enabled = !ChkIntegrated.Checked;
            txtusername.Enabled = !ChkIntegrated.Checked;
        }

        private void btnStartService_Click(object sender, EventArgs e)
        {
            var execpath = txtFolder.Text + "\\" + txtProjectName.Text.Trim() + "\\func start";
           

            File.WriteAllText(txtFolder.Text +"\\Run.bat", "CD " + txtFolder.Text + "\\" + txtProjectName.Text.Trim() + System.Environment.NewLine + "func start");

            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.FileName = txtFolder.Text + "\\Run.bat";
            p.Start();

            //  string output = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();

            Thread.Sleep(30000);
            System.Diagnostics.Process.Start("http://localhost:7071/api/swagger/ui");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabcontrolmain.TabPages.Add(tabKeyvault);
            tabcontrolmain.TabPages.Remove(TabProjectdetails);

        }

        private void chkKeyvault_CheckedChanged(object sender, EventArgs e)
        {
             grpKeyvault.Visible= chkKeyvault.Checked ;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
