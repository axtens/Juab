# JUAB جواب - the answer

If running a binary, sight unseen, is a concern:

 * Navigate to the folder where juab.csproj is located
 * type 'dotnet build'
 * If dotnet 6.x SDK is installed, the binary will be rebuilt.
 * If all you have is dotnet 5.x, edit the csproj, and change the TargetFramework to net5.0
 * Save the file and attempt a build.