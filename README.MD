# Blockchain API with C#.NET Core

In this repo, we will tackle the core concepts of BlockChain. That is Block, Hashing, and Proof of Work.
- Block holds the data, timestamp, and hash.
- Hash links to the previous Block.
- Proof of Work (POW) is a consenses for the validity and security of a Block.
- Chain is the series of block linked together.

### Prerequisites
 
We need a few nuget packages.<br />
```
dotnet add package Microsoft.AspNetCore.OpenApi
dotnet add package Swashbuckle.AspNetCore
```

### Running Locally

Navigate to the BlockChainAPI Project from the Terminal. See example to navigate when you in sms folder below. 
<br />
```
cd .\BlockChainAPI\
```

Run the web api
<br />
```
dotnet run
```

Check if the web api is running by hitting Health API Endpoint.
<br />
```
curl -X 'GET' \
  'http://localhost:5000/BlockChain/Health' \
  -H 'accept: */*'
```

Get all the BlockChain.
<br />
```
curl -X 'GET' \
  'http://localhost:5000/Blockchain/GetAllBlockchain' \
  -H 'accept: text/plain'
```

Add or mine a BlockChain.
<br />
```
curl -X 'POST' \
  'http://localhost:5000/Blockchain/AddBlockchain' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '"new block data here"'
```

Check if the BlockChain is valid. 
<br />
```curl -X 'GET' \
  'http://localhost:5000/Blockchain/isValid' \
  -H 'accept: */*'
```