using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nethereum;
using Nethereum.Web3;
using Nethereum.Contracts;
using Nethereum.ABI.FunctionEncoding.Attributes;

using NethereumTest.ERC20.Outputs;

namespace NethereumTest.ERC20.Functions
{
    /**
     * @dev Returns the symbol of the token.
     */
    // function symbol() external view returns (string memory);
    // Output - SymbolOutput.cs

    [Function("symbol", typeof(SymbolOutput))]
    public class SymbolFunction : FunctionMessage
    {
    }

}
