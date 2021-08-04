using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Enums
{
    public class ErrorMessage
    {

        public static string ERROR_400_BAD_NAME_OR_PASSWORD = "400 : Nom ou mot de passe utilisateur incorrect";
        public static string ERROR_500_CREATE_USER_ERROR= "500 : Erreur lors de la création de l'utilisateur";
        public static string ERROR_400_BAD_TOKEN= "400 : Le token retourné n'est pas valide";
        public static string ERROR_400_BAD_CITYNAME= "400 : La ville demandé n'a pas pu être trouvé";
    }
}
