

# build the project
dotnet build -c Release

# obtain the nuget pkgs we need to run the coverage testing
dotnet restore --packages .\packages .\dataprocessor.tests\

# run the unit tests using the OpenCover
.\packages\OpenCover\4.6.519\tools\OpenCover.Console.exe `
    -register:user `
    -target:"packages\NUnit.ConsoleRunner\3.8.0\tools\nunit3-console.exe" `
    -targetargs:"-domain=single dataprocessor.tests\bin\Release\net461\dataprocessor.tests.dll" `
    -output:".\coverage.xml" `
    -filter:"+[dataprocessor]*"

# produce the report
.\packages\ReportGenerator\3.1.2\tools\ReportGenerator.exe `
	-reports:coverage.xml `
	-targetdir:coverage