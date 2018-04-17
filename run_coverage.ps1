.\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe `
    -register:user `
    -target:"packages\NUnit.ConsoleRunner.3.8.0\tools\nunit3-console.exe" `
    -targetargs:"dataprocessor.tests\bin\Release\dataprocessor.tests.dll --result=TestResult.xml;format=AppVeyor" `
    -output:".\coverage.xml" `
    -filter:"+[dataprocessor*]* -[dataprocessor.tests*]*"

.\packages\ReportGenerator.3.1.2\tools\ReportGenerator.exe `
	-reports:coverage.xml `
	-targetdir:coverage