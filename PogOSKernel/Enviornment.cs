using System;
using System.Collections.Generic;
using System.Text;
namespace PogOS
{
    class Enviornment
    {
        public static void set_env(string name, string key)
        {
            try
            {
                Kernel.env_vars.Add(name, key);
            }
            catch
            {
                ErrorHandler.EnvVarError();
            }
        }
        public static void remove_env(string name)
        {
            try
            {
                Kernel.env_vars.Remove(name);
            }
            catch
            {
                ErrorHandler.EnvVarError();
            }
        }

    }
}
