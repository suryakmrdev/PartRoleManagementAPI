/*
 * Party Role Management
 *
 * This is Swagger UI environment generated for the TMF Party Role Management specification
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

global using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Linq;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PartyRoleManagementAPI.Models
{
    public partial class CreditProfile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string CreditProfileDate { get; set; }

        public long CreditRiskRating { get; set; }

        public long CreditScore { get; set; }


        public TimePeriod ValidFor { get; set; }
    }
}
