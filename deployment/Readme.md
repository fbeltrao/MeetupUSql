# Deploying the Data Factory to Azure using templates

## Deploying using Azure Portal
<a href="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Ffbeltrao%2FMeetupUSql%2Fmaster%2Fdeployment%2Fazuredeploy.json" target="_blank">
    <img src="http://azuredeploy.net/deploybutton.png"/>
</a>

## Deploying using powershell

Copy the files in this repository locally, then change the parameters.json file according to your resource and secret names.

```powershell
Login-AzureRmAccount

New-AzureRmResourceGroupDeployment -ResourceGroupName <resource group> -TemplateFile .\azuredeploy.json -TemplateParameterFile .\parameters.json
```

## Deploying using az cli
```cmd
az group deployment create \
    --name DataFactoryMeetup \
    --resource-group <resource group> \
    --template-uri "https://raw.githubusercontent.com/fbeltrao/MeetupUSql/master/deployment/azuredeploy.json"
```
