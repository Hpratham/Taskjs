using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace ClothShop_Project
{
    
    internal class Class1
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-11G9KID6\\SQLEXPRESS;Initial Catalog=\"Product Database\";Integrated Security=True");
        // private string text1;
        //private string text2;
        //private string text3;
        //private string text4;
        //private string gender;

        public string UserType { get; set; }
        [Required]

        public string UserName { get; set; }
        [Required]
        public string UserGender { get; set; }
        [Required]
        public int UserPassword { get; set; }
        [Required]
        public string UserState { get; set; }
        [Required]
        public int TypeID { get; set; }
        [Required]
        public string TypeName { get; set; }

        public string ProductName { get; set; }

        public int ProductID { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public int MRP { get; set; }
        [Required]
        public int RPrice { get; set; }

        public int SizeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }

        public int pass { get; set; }

        public int UserID { get; set; }
        public string Status { get; set; }

        public string Date { get; set; }
        public string OrderID{get;set;}
        [Required]
        public string Discount { get; set; }
        public int NewPrice { get; set; }
        public string  NewName { get; set; }

       
        public Class1(string orderid, string discount,int newprice)
        {
            OrderID = orderid;
            Discount = discount;
            NewPrice = newprice;
           

        }
        public Class1(string text)
        {
            NewName= text;
        }

        public Class1(string userType, string userName, string userGender, int userPassword, string userState)
        {
            UserType = userType;
            UserName = userName;
            UserGender = userGender;
            UserPassword = userPassword;

            UserState = userState;
        }
        public Class1(string userType, string userName, int password, int userId)
        {
            UserType= userType;
            UserName = userName;
            UserPassword = password;
            UserID = userId;
         
        }


        public Class1(int Pid, string size, int mrp, int rmrp)
        {
            ProductID = Pid;
            Size = size;
            MRP = mrp;
            RPrice = rmrp;
        }


       public Class1(int Sizeid,int userid,string status,string date)
        {
            SizeID= Sizeid;
            UserID = userid;
            Status = status;
            Date = date;
        }

        //public Class1(string typeName)
        //{
        //    TypeName = typeName;
        //}
        public Class1(int Typeid,string Productname)
        {
            TypeID = Typeid;
            ProductName = Productname;
        }
        public Class1(int Typeid)
        {
            TypeID = Typeid;
        }

        public Class1()
        {
        }

        public Class1(string text, int orderId) : this(text)
        {
        }

        //public Class1(int productID)
        //{
        //    ProductID= productID;
        //}
        public void SetSize(int sizeid)
        {

            SizeID = sizeid;
        }
        public void Order(string name1,  int Pass)
        {
           Name = name1;
            pass = Pass;
           

        }
        
     

        public void Save()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Save");
            cmd.Parameters.AddWithValue("@UserType", UserType);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@UserGender", UserGender);
            cmd.Parameters.AddWithValue("@UserPassword", UserPassword);
            cmd.Parameters.AddWithValue("@UserState", UserState);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public SqlDataReader Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CheckData");
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@UserPassword", UserPassword);
            cmd.Parameters.AddWithValue("@UserType", UserType);
           // cmd.Parameters.AddWithValue("@UID",UserID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();


        }
        public void SaveType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveType");
            cmd.Parameters.AddWithValue("@TypeName", TypeName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetAllType()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("cloths", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Flag", "GetType");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            con.Close();
            return dt;
        }
        public void saveproductData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "saveproductData");
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@TypeID", TypeID);


            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SaveSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveSizeData");

            cmd.Parameters.AddWithValue("@ProductID", ProductID);
            cmd.Parameters.AddWithValue("@Size", Size);
            cmd.Parameters.AddWithValue("@MRP", MRP);  
            cmd.Parameters.AddWithValue("@RPrice", RPrice);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable GetAllProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "selectProduct");
            cmd.Parameters.AddWithValue("@TypeID", TypeID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            return dt;
            con.Close();
        }
        public DataTable selectProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "selectProduct");
            cmd.Parameters.AddWithValue("@TypeID", ProductID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            return dt;
            con.Close();
        }
        public DataTable Order()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SizeColumn");
            cmd.Parameters.AddWithValue("@ProductID ", TypeID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //public DataTable SaveSizeID()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("cloth", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "SaveSizeID");
        //    cmd.Parameters.AddWithValue("@SizeID ", SizeID);
        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    adpt.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    adpt.Fill(dt);
        //    return dt;
        //    con.Close();
        //}
        public SqlDataReader Price()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SavePrice");
            cmd.Parameters.AddWithValue("@SizeID", TypeID);
            SqlDataReader dr;
                dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }
        public void OData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Cloths", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ORClick");
            cmd.Parameters.AddWithValue("@SizeID", SizeID);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Status", Status );
            cmd.Parameters.AddWithValue("@Date", Date);
           cmd.ExecuteNonQuery();   
            con.Close();

        }
        public DataTable Fetch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Admin");
            SqlDataAdapter adpt=new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt= new DataTable();
            adpt.Fill(dt);
           
            con.Close();
            return dt;


        }
        public DataTable Order1()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Select");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            con.Close();
            return dt;

        }
        public void UpdatenewPrice()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Update");
            cmd.Parameters.AddWithValue("@OrderID", OrderID);
            cmd.Parameters.AddWithValue("@Discount", Discount);
          
            
            cmd.ExecuteNonQuery();
            con.Close(); 
        }
        public DataTable UnorderedCustomer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnorderedCustomer");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            con.Close();
            return dt;

        }
        public DataTable UnorderedProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnorderedProduct");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            con.Close();
            return dt;
        }
        public void Delete()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FLag", "Delete");
            cmd.Parameters.AddWithValue("@OrderID", NewName);
            cmd.Parameters.AddWithValue("@isdeleted", 1);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable Refresh() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("cloths", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Select");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            con.Close();
            return dt;



        }


    }

    internal class RequiredAttribute : Attribute
    {
    }
}
