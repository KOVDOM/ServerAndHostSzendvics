using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace Server
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]

        Szedvics EgySzendvicsGetCS();

        [OperationContract]

        [WebInvoke(Method = "GET", 
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate ="/EgySzendvicsGet/"
            )]

        Szedvics EgySzendvicsGet();

        [OperationContract]

        string EgySzendvicsPostCS(Szedvics szedvics);

        [OperationContract]

        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/EgySzendvicsPost/"
            )]

        string EgySzendvicsPost(Szedvics szedvics);

        [OperationContract]

        String EgySzendvicsPutCS(Szedvics szedvics);

        [OperationContract]

        [WebInvoke(Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/EgySzendvicsPut/"
            )]

        String EgySzendvicsPut(Szedvics szedvics);

        [OperationContract]
        String EgySzendvicsDeleteCS(int id);

        [OperationContract]

        [WebInvoke(Method = "DELETE",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/EgySzendvicsDelete?id={id}"
            )]

        string EgySzendvicsDelete(int id);


        [OperationContract]

        List<Szedvics> EgySzendvicsGetListCS();

        [OperationContract]

        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/EgySzendvicsGetList"
            )]

        List<Szedvics> EgySzendvicsGetList();
    }

    [DataContract]

    public class Szedvics:Record
    {
        [DataMember]
        public string PekaruTipusa { get; set; }

        [DataMember]

        public string HusFeltet { get; set; }

        [DataMember]

        public string Vaj { get; set; }

        [DataMember]
        public bool Szalveta { get; set; }

        [DataMember]

        public byte SzalamiKarikakSzama { get; set; }

        [DataMember]

        public string ZoldsegFeltet { get; set; }

    }

    [DataContract]
    public class Record
    {
        [DataMember]

        public int? Id { get; set; }
    }
}
