 namespace Demo.Models;
 
    public enum FormState : int
    {
        SAVED, TEMP, EDITED
    }
    public class Hosts
    {
        public List<Host> hosts { get; set; }
    }
    // C# Model matching the JSON structure
    public class Host
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string SubnetId { get; set; }
        public string Subnet { get; set; }
        public string Info { get; set; }
        public List<Domain> Domains { get; set; }
        public List<Port> Ports { get; set; }
        public List<Tag> Tags { get; set; }
        public FormState State {get; set;}
    }
    public class Tag {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Info { get; set; }
    }
    public class Port {
        public int Id { get; set; }
        public int Number { get; set; }
        public string? Info { get; set; }
        public int HostId { get; set; } 
        public string Protocol { get; set; }
        public string? Banner { get; set; }
        public FormState State {get; set;}
    }
    public class Domains {
        public List<Domain> domains { get; set; }
    }
    public class Domain {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Info { get; set; }
        public List<int> HostIds {get; set; }
        public FormState State {get; set;}
    }
    public class Site
    {
        public int Id { get; set; }
    }