using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosApp.Infra.Security.Settings
{
    public class JwtTokenSettings
    {
        public static string SecretKey = "EB1AB146-C07B-48D0-81FD-C42AF391790FA";

        public static int ExpirationInHours = 1;
    }
}
