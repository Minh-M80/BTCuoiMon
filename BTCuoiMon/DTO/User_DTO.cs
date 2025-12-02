using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiMon.DTO
{
    public class User_DTO
    {
        String username;
        String passwor;
        String id_Nv;
        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        public String Password
        {
            get { return passwor; }
            set { passwor = value; }
        }
        public String Id_Nv
        {
            get { return id_Nv; }
            set { id_Nv = value; }
        }
    }
}
