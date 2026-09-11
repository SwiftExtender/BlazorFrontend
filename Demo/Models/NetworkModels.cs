namespace Demo.Models;

public enum FormState : int
{
    SAVED, TEMP, EDITED
}
public class PagedResponse
{
    public List<Host> hosts { get; set; }
    public int currentPage { get; set; }
    public int totalPages { get; set; }
}
//public class Hosts
//{
//    public List<Host> hosts { get; set; }
//}
public class Host
{
    public int Id { get; set; }
    public string Ip { get; set; }
    public int? SubnetId { get; set; }
    public Subnet? Subnet { get; set; }
    public string? Info { get; set; }
    public List<Domain>? Domains { get; set; }
    public List<Port>? Ports { get; set; }
    public List<Tag>? Tags { get; set; }
    public FormState State { get; set; }
}
public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Info { get; set; }
}
public class Port
{
    public int Id { get; set; }
    public int Number { get; set; }
    public string? Info { get; set; }
    public int HostId { get; set; }
    public string Protocol { get; set; }
    public string? Banner { get; set; }
    public FormState State { get; set; }
}
public class Domains
{
    public List<Domain> domains { get; set; }
}
public class Domain
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string? Info { get; set; }
    public List<int> HostIds { get; set; }
    public FormState State { get; set; }
}
public class Site
{
    public int Id { get; set; }
}
public class RelatedImportRequest
{
    public string RelationType { get; set; }
    public string Data { get; set; }
    public string? Tag { get; set; }
}
public class Subnet
{

    public int Id { get; set; }
    public string Cidr { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}