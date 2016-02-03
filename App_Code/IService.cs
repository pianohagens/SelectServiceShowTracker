using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    List<ShowInfo> GetShowsByVenue(string venueName);

}


[DataContract]
public class ShowInfo
{
    [DataMember]
    public string ArtistName { get; set; }
    [DataMember]
    public string ShowName { get; set; }
    [DataMember]
    public string ShowDate { get; set; }
    [DataMember]
    public string ShowTime { get; set; }

    [DataMember]
    public string TicketDetail { get; set; }
}