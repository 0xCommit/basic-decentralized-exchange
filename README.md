# basic-decentralized-exchange
Decentralized exchanges allow parties to trade and transfer assets between each other without the users holding and risking their funds on a centralized intermediary. This implementation of a decentralized exchange (DEX) uses a single smart contract that allows users to deposit and withdraw funds, create & cancel orders and execute/fill orders. This contract uses similar logic to older decentralzied exchanges such as Etherdelta, as opposed to newer models such as Uniswap.

The architecture of this DEX consists of two parts - the Solidity contracts required for the DEX, and a user interface to interact with the DEX. I wanted to try the [Nethereum library](https://github.com/Nethereum/Nethereum), a .NET Ethereum integration library, at the time of creating this project, and as such the user interface is a C# Windows desktop program.

## Purpose
This project was created as a fun way to continue my Solidity learning. A full, working decentralized exchange was created that would actually allow two users to trade assets between each other in a decentralized manner, which I thought was cool.

## Solidity Contracts
### Exchange.sol
This contract contains all the logic and functionality required for users to deposit and withdraw ether & tokens, create and cancel orders, execute/fulfill orders and perform the necessary transfer of assets.

Users are able to deposit/withdraw ether/tokens to/from the smart contract, where the contract will store the users balances.

Users can create orders, which are represnted as structs and stored in a mapping. Users are able to cancel unfulfilled orders that they created.

A user (the taker) will execute against an order, either fully or partially, that has been created by another user (the maker). The contract will then update the users balances accordingly. 

### ERC20/...
The necessary Solidity files that represent ERC20 tokens. Uses the OpenZeppelin ERC20 standard.

## Nethereum (Not Complete)
The user interface for this DEX was to be created in C# using the Nethereum library, creating a complete desktop GUI program. However, it is not fully finished, as the actual GUI was not completed, however all necessary methods around the smart contract methods were created and implemented in C#.

In NethereumTest/NethereumTest/Program.cs, all wrapper functions around the Exchange smart contract are there, working. These methods allow you to programmatically through C# interact with the Exchange smart contract. For my purposes (fun + testing), I ended up just using a console program and these methods to interact with the Exchange.

