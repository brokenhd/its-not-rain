using System.Xml;
using System.Xml.Serialization;

public class Enemies {
	[XmlAttribute("name")]
	public string Name{get; set;}

	// Makes it possible to retrive nested arrays from the XML. Make sure a seprate class for this data is prepared
	[XmlElement("Nested")]
	public Nested[] Nested;

	public int health;
	public int Health {
		get{

			health = health + (Level * Level);
			return health;
		}
		set {
			health = value;
		}
	}
	public int Level{get; set;}
}

//Prepared a class for the incomming nested xml.
public class Nested {
	[XmlAttribute("name")]
	public string Name{get; set;}

	public bool Boss{get; set;}
}


public class Items {
	[XmlAttribute("name")]
	public string Name{get; set;}
	public float Price{get; set;}
	public string Info{get; set;}
}