// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for SubstanceAmount
  /// </summary>
  public static class SubstanceAmountJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR SubstanceAmount into JSON
    /// </summary>
    public static void SerializeJson(this SubstanceAmount current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: SubstanceAmount, Export: SubstanceAmount, Base: BackboneElement (BackboneType)
      ((Hl7.Fhir.Model.BackboneType)current).SerializeJson(writer, options, false);

      if (current.Amount != null)
      {
        switch (current.Amount)
        {
          case Quantity v_Quantity:
            writer.WritePropertyName("amountQuantity");
            v_Quantity.SerializeJson(writer, options);
            break;
          case Range v_Range:
            writer.WritePropertyName("amountRange");
            v_Range.SerializeJson(writer, options);
            break;
          case FhirString v_FhirString:
            writer.WriteString("amountString",v_FhirString.Value);
            break;
        }
      }
      if (current.AmountType != null)
      {
        writer.WritePropertyName("amountType");
        current.AmountType.SerializeJson(writer, options);
      }

      if ((current.AmountTextElement != null) && (current.AmountTextElement.Value != null))
      {
        writer.WriteString("amountText",current.AmountTextElement.Value);
      }

      if (current.ReferenceRange != null)
      {
        writer.WritePropertyName("referenceRange");
        current.ReferenceRange.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceAmount
    /// </summary>
    public static void DeserializeJson(this SubstanceAmount current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceAmount
    /// </summary>
    public static void DeserializeJsonProperty(this SubstanceAmount current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "amountQuantity":
          current.Amount = JsonSerializer.Deserialize<Hl7.Fhir.Model.Quantity>(ref reader, options);
          break;

        case "amountRange":
          current.Amount = JsonSerializer.Deserialize<Hl7.Fhir.Model.Range>(ref reader, options);
          break;

        case "amountString":
          current.Amount = new FhirString(reader.GetString());
          break;

        case "amountType":
          current.AmountType = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "amountText":
          current.AmountTextElement = new FhirString(reader.GetString());

          break;

        case "referenceRange":
          current.ReferenceRange = JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent>(ref reader, options);

          break;

        // Complex: SubstanceAmount, Export: SubstanceAmount, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneType)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstanceAmount#ReferenceRange into JSON
    /// </summary>
    public static void SerializeJson(this SubstanceAmount.ReferenceRangeComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      if (current.LowLimit != null)
      {
        writer.WritePropertyName("lowLimit");
        current.LowLimit.SerializeJson(writer, options);
      }

      if (current.HighLimit != null)
      {
        writer.WritePropertyName("highLimit");
        current.HighLimit.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceAmount#ReferenceRange
    /// </summary>
    public static void DeserializeJson(this SubstanceAmount.ReferenceRangeComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceAmount#ReferenceRange
    /// </summary>
    public static void DeserializeJsonProperty(this SubstanceAmount.ReferenceRangeComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "lowLimit":
          current.LowLimit = JsonSerializer.Deserialize<Hl7.Fhir.Model.Quantity>(ref reader, options);

          break;

        case "highLimit":
          current.HighLimit = JsonSerializer.Deserialize<Hl7.Fhir.Model.Quantity>(ref reader, options);

          break;

      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SubstanceAmountJsonConverter : JsonConverter<SubstanceAmount>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(SubstanceAmount).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, SubstanceAmount value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override SubstanceAmount Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        SubstanceAmount target = new SubstanceAmount();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
