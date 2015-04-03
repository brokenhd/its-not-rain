using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("EnemiesCollection")]
public class EnemyContainer
{
	[XmlArray("Enemies"),XmlArrayItem("Enemy")]
	public Enemies[] Enemies;

	public void Save(string path)
	{
		var serializer = new XmlSerializer(typeof(EnemyContainer));
		using(var stream = new FileStream(path, FileMode.Create))
		{
			serializer.Serialize(stream, this);
		}
	}
	
	public static EnemyContainer Load(string path)
	{
		var serializer = new XmlSerializer(typeof(EnemyContainer));
		using(var stream = new FileStream(path, FileMode.Open))
		{
			return serializer.Deserialize(stream) as EnemyContainer;
		}
	}
	
	//Loads the xml directly from the given string. Useful in combination with www.text.
	public static EnemyContainer LoadFromText(string text) 
	{
		var serializer = new XmlSerializer(typeof(EnemyContainer));
		return serializer.Deserialize(new StringReader(text)) as EnemyContainer;
	}
}