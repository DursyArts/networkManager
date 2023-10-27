
string generateMAC() {
    string macAddress = "";
    
    Random rnd = new Random();
    int randomMACBlock;
    string[] macBlock = new string[6];
    
    //6 bytes
    for(int i = 0; i < 6;i++) {
        randomMACBlock = rnd.Next(0, 255);
        macBlock[i] = randomMACBlock.ToString("X2");
        Console.WriteLine("Generated random number: " + randomMACBlock);
        Console.WriteLine("Parsed into byte as: " + macBlock[i]);
    }

    //build mac
    macAddress = macBlock[0] + ":" + macBlock[1] + ":" + macBlock[2] + ":" + macBlock[3] + ":" + macBlock[4] + ":" + macBlock[5];

    return macAddress;
}

Console.WriteLine(generateMAC());