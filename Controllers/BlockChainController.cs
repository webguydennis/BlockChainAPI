using BlockChainAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlockChainAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlockchainController : ControllerBase
    {
        private static readonly Blockchain blockchain = new Blockchain();

        /// <summary>
        /// Health Check
        /// </summary>
        [HttpGet("Health")]
        public IActionResult Health() {
            return Ok("Healthy. It Works.");
        }
        
        /// <summary>
        /// Get the entire blockchain
        /// </summary>
        [HttpGet("GetAllBlockchain")]
        public IEnumerable<Block> GetAllBlockchain()
        {
            return blockchain.Chain;
        }
        
        /// <summary>
        /// Add a new block with data
        /// </summary>
        [HttpPost("AddBlockchain")]
        public IActionResult AddBlocklain([FromBody] string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return BadRequest("Block data cannot be empty.");
            }

            var newBlock = new Block(blockchain.Chain.Count, DateTime.Now, data);
            blockchain.AddBlock(newBlock);
            return Ok(new { message = "Block added successfully", blockchain = blockchain.Chain });
        }

        /// <summary>
        /// Check if the blockchain is valid
        /// </summary>
        [HttpGet("isValid")]
        public IActionResult CheckValidity()
        {
            bool isValid = blockchain.IsValid();
            return Ok(new { message = isValid ? "Blockchain is valid" : "Blockchain is NOT valid", status = isValid });
        }
    }
}

