using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Project {
    public static class DataSerializer {
        public static void binarySerialize(object obj, string filePath) {
            try {
                FileStream fstream;
                BinaryFormatter bformatter = new BinaryFormatter();
                if (File.Exists(filePath)) File.Delete(filePath);
                fstream = File.Create(filePath);
                bformatter.Serialize(fstream, obj);
                fstream.Close();
            } catch(Exception ex) {
                MessageBox.Show("Exception occurred: " + ex.Message);
            }
        }

        public static object binaryDeserialize(string filePath) {
            Object obj = null;
            try {
                FileStream fstream;
                BinaryFormatter bformatter = new BinaryFormatter();
                fstream = File.OpenRead(filePath);
                obj = bformatter.Deserialize(fstream);
                fstream.Close();
            } catch (Exception ex) {
                MessageBox.Show("Exception occurred: " + ex.Message);
            }
            return obj;
        }
    }
}
