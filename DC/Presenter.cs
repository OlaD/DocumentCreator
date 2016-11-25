using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DC
    {
    class Presenter
    {
		MainWindow view;

		public Presenter(MainWindow view)
		{
		    this.view = view;
		}

        // test:
        // pola w view będą miały odpowiednie wartości
		public void loadDataToFields(string path)
		{
            XmlDocument xmlDocument = loadDataFromXML(path);
            bool isCorrect = validateData(xmlDocument);
            if (isCorrect)
            {
                //fillFields(document);
            };
        }

        // test:
        // dokument będzie miał odpowiednie wartości
        private XmlDocument loadDataFromXML(string path)
        {
            Serializer<Wniosek> serializer = new Serializer<Wniosek>();
            Wniosek document = serializer.loadFromXML(path);
            XmlDocument xmlDocument = serializer.loadToXML(document);
            return xmlDocument;
        }

        // test:
        // poprawny dokument zwróci true
        // zły zwróci false
        private bool validateData(XmlDocument xmlDocument)
        {
            Validator validator = new Validator();
            bool isCorrect = validator.ValidateAll(xmlDocument, false);
            return isCorrect;
        }
    }
}
