using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
//using System.Web.Extension.dll;

namespace Atom
{
   
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Atom.DisplayElements(Atom.GetAtoms());
            Atom.WriteJson(Atom.GetAtoms(),"Atoms_list_file.json");
            Atom.ReadJson("Atoms_list_file.json");
            Atom.WriteXml(Atom.GetAtoms(), "First_atom.xml");
            Atom.WriteFirstAtomJson(Atom.GetAtoms()[0], "First_Atom.json");
            Atom.ReadFirstAtomJson("First_Atom.json");
        }
    }
}

