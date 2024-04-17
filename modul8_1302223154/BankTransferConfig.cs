using System;
using System.Text.Json;

class Config
	{
	public string Lang { get; set; }
	public int Threshold { get; set; }
	public int Low_fee { get; set; }
	public int High_fee { get; set; } 
	public string Methods { get; set; }
	public string En { get; set; }
	public string Id { get; set; }

	public Config() { }

	public Config(string lang, int threshold, int low_fee, int high_fee, string methods, string en, string id)
	{
		Lang = lang;
		Threshold = threshold;
		Low_fee = low_fee;
		High_fee = high_fee;
		Methods = methods;
		En = en;
		Id = id;
	}
}
class BankTransferConfig
	{
	public Config config;
	public const string filepath = @"bank_transfer_config.json";
	public BankTransferConfig() { }

    private Config ReadConfigFile()
    {
		string configJsonData = File.ReadAllText(filepath);
        config = JsonSerializer.Deserialize<Config>(configJsonData);
        return config;
    }

    private void WriteNewConfigFile()
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
			WriteIndented = true
        };
        String jsonString = JsonSerializer.Serialize(config, options);
        File.WriteAllText(filepath, jsonString);
    }

	public void SetDefault()
	{
		config.Lang = "en";
		config.Threshold = 25000000;
		config.Low_fee = 6500;
		config.High_fee = 15000;

		config.En = "yes";
		config.Id = "ya";
    }
}
