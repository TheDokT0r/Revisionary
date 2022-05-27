using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisionary
{
    /*
     * Encrypts the profile files
     * Not the hardest encryption to solve, but it's an encryption that was made for an offline applicatio, so it doesn't matter that much.
     * If you still wanna break the encryption, enjoy I guess?
     * - Hasn't been added yet cause I don't care enough
     */
    public class ProfileEncryptor
    {
        static string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.Revisionary";
        static string profileDir = rootPath + "/usr/";
        static string usrDataFile = profileDir + "/pf.you";
        static string usrStuts = profileDir + "/stuts.you";

        static void EncryptPf()
        {

        }
    }
}
