/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// FormatTest
    /// </summary>
    [DataContract(Name = "format_test")]
    public partial class FormatTest : IEquatable<FormatTest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormatTest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        /// <param name="integer">integer.</param>
        /// <param name="int32">int32.</param>
        /// <param name="int64">int64.</param>
        /// <param name="number">number (required).</param>
        /// <param name="_float">_float.</param>
        /// <param name="_double">_double.</param>
        /// <param name="_decimal">_decimal.</param>
        /// <param name="_string">_string.</param>
        /// <param name="_byte">_byte (required).</param>
        /// <param name="binary">binary.</param>
        /// <param name="date">date (required).</param>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="password">password (required).</param>
        /// <param name="patternWithDigits">A string that is a 10 digit number. Can have leading zeros..</param>
        /// <param name="patternWithDigitsAndDelimiter">A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01..</param>
        // public FormatTest(int integer = default(int), int int32 = default(int), long int64 = default(long), decimal number = default(decimal), float _float = default(float), double _double = default(double), decimal _decimal = default(decimal), string _string = default(string), byte[] _byte = default(byte[]), System.IO.Stream binary = default(System.IO.Stream), DateTime date = default(DateTime), DateTime dateTime = default(DateTime), Guid uuid = default(Guid), string password = default(string), string patternWithDigits = default(string), string patternWithDigitsAndDelimiter = default(string))
        public FormatTest(int integer = default, int int32 = default, long int64 = default, decimal number, float _float = default, double _double = default, decimal _decimal = default, string _string = default, byte[] _byte, System.IO.Stream binary = default, DateTime date, DateTime dateTime = default, Guid uuid = default, string password, string patternWithDigits = default, string patternWithDigitsAndDelimiter = default)
        {
            this.Number = number;
            // to ensure "_byte" is required (not null)
            if (_byte == null) {
                throw new ArgumentNullException("_byte is a required property for FormatTest and cannot be null");
            }
            this.Byte = _byte;
            this.Date = date;
            // to ensure "password" is required (not null)
            if (password == null) {
                throw new ArgumentNullException("password is a required property for FormatTest and cannot be null");
            }
            this.Password = password;
            this.Integer = integer;
            this.Int32 = int32;
            this.Int64 = int64;
            this.Float = _float;
            this.Double = _double;
            this.Decimal = _decimal;
            this.String = _string;
            this.Binary = binary;
            this.DateTime = dateTime;
            this.Uuid = uuid;
            this.PatternWithDigits = patternWithDigits;
            this.PatternWithDigitsAndDelimiter = patternWithDigitsAndDelimiter;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Integer
        /// </summary>
        [DataMember(Name = "integer", EmitDefaultValue = false)]
        // public int Integer { get; set; }
        public int Integer { get; set; } // c

        /// <summary>
        /// Gets or Sets Int32
        /// </summary>
        [DataMember(Name = "int32", EmitDefaultValue = false)]
        // public int Int32 { get; set; }
        public int Int32 { get; set; } // c

        /// <summary>
        /// Gets or Sets Int64
        /// </summary>
        [DataMember(Name = "int64", EmitDefaultValue = false)]
        // public long Int64 { get; set; }
        public long Int64 { get; set; } // c

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = false)]
        // public decimal Number { get; set; }
        public decimal Number { get; set; } // c

        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [DataMember(Name = "float", EmitDefaultValue = false)]
        // public float Float { get; set; }
        public float Float { get; set; } // c

        /// <summary>
        /// Gets or Sets Double
        /// </summary>
        [DataMember(Name = "double", EmitDefaultValue = false)]
        // public double Double { get; set; }
        public double Double { get; set; } // c

        /// <summary>
        /// Gets or Sets Decimal
        /// </summary>
        [DataMember(Name = "decimal", EmitDefaultValue = false)]
        // public decimal Decimal { get; set; }
        public decimal Decimal { get; set; } // c

        /// <summary>
        /// Gets or Sets String
        /// </summary>
        [DataMember(Name = "string", EmitDefaultValue = false)]
        // public string String { get; set; }
        public string String { get; set; } // c

        /// <summary>
        /// Gets or Sets Byte
        /// </summary>
        [DataMember(Name = "byte", IsRequired = true, EmitDefaultValue = false)]
        // public byte[] Byte { get; set; }
        public byte[] Byte { get; set; } // c

        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [DataMember(Name = "binary", EmitDefaultValue = false)]
        // public System.IO.Stream Binary { get; set; }
        public System.IO.Stream Binary { get; set; } // c

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        // public DateTime Date { get; set; }
        public DateTime Date { get; set; } // c

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name = "dateTime", EmitDefaultValue = false)]
        // public DateTime DateTime { get; set; }
        public DateTime DateTime { get; set; } // c

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        // public Guid Uuid { get; set; }
        public Guid Uuid { get; set; } // c

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = false)]
        // public string Password { get; set; }
        public string Password { get; set; } // c

        /// <summary>
        /// A string that is a 10 digit number. Can have leading zeros.
        /// </summary>
        /// <value>A string that is a 10 digit number. Can have leading zeros.</value>
        [DataMember(Name = "pattern_with_digits", EmitDefaultValue = false)]
        // public string PatternWithDigits { get; set; }
        public string PatternWithDigits { get; set; } // c

        /// <summary>
        /// A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.
        /// </summary>
        /// <value>A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.</value>
        [DataMember(Name = "pattern_with_digits_and_delimiter", EmitDefaultValue = false)]
        // public string PatternWithDigitsAndDelimiter { get; set; }
        public string PatternWithDigitsAndDelimiter { get; set; } // c

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FormatTest {\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("  Decimal: ").Append(Decimal).Append("\n");
            sb.Append("  String: ").Append(String).Append("\n");
            sb.Append("  Byte: ").Append(Byte).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PatternWithDigits: ").Append(PatternWithDigits).Append("\n");
            sb.Append("  PatternWithDigitsAndDelimiter: ").Append(PatternWithDigitsAndDelimiter).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as FormatTest).AreEqual;
        }

        /// <summary>
        /// Returns true if FormatTest instances are equal
        /// </summary>
        /// <param name="input">Instance of FormatTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormatTest input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Integer.GetHashCode();
                hashCode = (hashCode * 59) + this.Int32.GetHashCode();
                hashCode = (hashCode * 59) + this.Int64.GetHashCode();
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                hashCode = (hashCode * 59) + this.Float.GetHashCode();
                hashCode = (hashCode * 59) + this.Double.GetHashCode();
                hashCode = (hashCode * 59) + this.Decimal.GetHashCode();
                if (this.String != null)
                {
                    hashCode = (hashCode * 59) + this.String.GetHashCode();
                }
                if (this.Byte != null)
                {
                    hashCode = (hashCode * 59) + this.Byte.GetHashCode();
                }
                if (this.Binary != null)
                {
                    hashCode = (hashCode * 59) + this.Binary.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.DateTime != null)
                {
                    hashCode = (hashCode * 59) + this.DateTime.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.PatternWithDigits != null)
                {
                    hashCode = (hashCode * 59) + this.PatternWithDigits.GetHashCode();
                }
                if (this.PatternWithDigitsAndDelimiter != null)
                {
                    hashCode = (hashCode * 59) + this.PatternWithDigitsAndDelimiter.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Integer (int) maximum
            if (this.Integer > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value less than or equal to 100.", new [] { "Integer" });
            }

            // Integer (int) minimum
            if (this.Integer < (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value greater than or equal to 10.", new [] { "Integer" });
            }

            // Int32 (int) maximum
            if (this.Int32 > (int)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value less than or equal to 200.", new [] { "Int32" });
            }

            // Int32 (int) minimum
            if (this.Int32 < (int)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value greater than or equal to 20.", new [] { "Int32" });
            }

            // Number (decimal) maximum
            if (this.Number > (decimal)543.2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value less than or equal to 543.2.", new [] { "Number" });
            }

            // Number (decimal) minimum
            if (this.Number < (decimal)32.1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value greater than or equal to 32.1.", new [] { "Number" });
            }

            // Float (float) maximum
            if (this.Float > (float)987.6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Float, must be a value less than or equal to 987.6.", new [] { "Float" });
            }

            // Float (float) minimum
            if (this.Float < (float)54.3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Float, must be a value greater than or equal to 54.3.", new [] { "Float" });
            }

            // Double (double) maximum
            if (this.Double > (double)123.4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Double, must be a value less than or equal to 123.4.", new [] { "Double" });
            }

            // Double (double) minimum
            if (this.Double < (double)67.8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Double, must be a value greater than or equal to 67.8.", new [] { "Double" });
            }

            // String (string) pattern
            Regex regexString = new Regex(@"[a-z]", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            if (false == regexString.Match(this.String).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for String, must match a pattern of " + regexString, new [] { "String" });
            }

            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 64.", new [] { "Password" });
            }

            // Password (string) minLength
            if (this.Password != null && this.Password.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 10.", new [] { "Password" });
            }

            // PatternWithDigits (string) pattern
            Regex regexPatternWithDigits = new Regex(@"^\\d{10}$", RegexOptions.CultureInvariant);
            if (false == regexPatternWithDigits.Match(this.PatternWithDigits).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithDigits, must match a pattern of " + regexPatternWithDigits, new [] { "PatternWithDigits" });
            }

            // PatternWithDigitsAndDelimiter (string) pattern
            Regex regexPatternWithDigitsAndDelimiter = new Regex(@"^image_\\d{1,3}$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            if (false == regexPatternWithDigitsAndDelimiter.Match(this.PatternWithDigitsAndDelimiter).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithDigitsAndDelimiter, must match a pattern of " + regexPatternWithDigitsAndDelimiter, new [] { "PatternWithDigitsAndDelimiter" });
            }

            yield break;
        }
    }

}
