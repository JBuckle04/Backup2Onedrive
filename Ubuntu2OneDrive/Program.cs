using System.IO.Compression;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Backup2OneDrive by James :), please change file directories in source if used for your own purposes");
string SourceFolder = @"C:\Users\James\VirtualBox VMs\UbuntuMain";
string zipFile = @"C:\Users\James\VirtualBox VMs\Result.zip";
string DestinationFolder = @"C:\Users\James\OneDrive - University of St Andrews\Virtualbox Backup\UbunBoxBackup.zip";
try
{
     ZipFile.CreateFromDirectory(SourceFolder,zipFile); //appears working, need to investiage further 
    Console.WriteLine("Zip File Created Succesfully");
}
catch
{
    Console.WriteLine("An Error Occured When Creating Zip File");
}
try
{
    //File.Copy(zipFile, DestinationFolder, true); //this is fucked
    Console.WriteLine("Backup Successful!");
    File.Copy(zipFile, DestinationFolder, true);
    File.Delete(zipFile);
}
catch
{
    Console.WriteLine("An Error Occured!");
}