# Using vscode project

Ensure [Azure Data Lake Tools](https://marketplace.visualstudio.com/items?itemName=usqlextpublisher.usql-vscode-ext) extensions is installed.

1. Make sure you can see in "DATALAKE EXPLORER" your Azure Data Lake Analytics resources (you will need to login to Azure from vscode)

1. Submit the job '01-CreateDatabase.usql' to create the Meetup database. You can submit a job by opening the file and right clicking and in the menu select "ADL: Submit job" (or ⌘Q + ⌘S)

1. Copy the assembly files in 'lib' folder to the Data Lake Store (i.e. /meetup/lib)

1. Register the assemblies by submitting job '02-CreateAssemblies.usql'

1. Edit the file '03-ExtractCSV.usql' setting the correct path for the input files. Then submit the job which will generate a single .csv file with all parsed content once completed (it can take a few minutes depending on how many files you Data Lake Store has.