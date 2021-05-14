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
  /// JSON Serialization Extensions for MarketingStatus
  /// </summary>
  public static class MarketingStatusJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR MarketingStatus into JSON
    /// </summary>
    public static void SerializeJson(this MarketingStatus current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: MarketingStatus, Export: MarketingStatus, Base: BackboneElement (BackboneType)
      ((Hl7.Fhir.Model.BackboneType)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("country");
      current.Country.SerializeJson(writer, options);

      if (current.Jurisdiction != null)
      {
        writer.WritePropertyName("jurisdiction");
        current.Jurisdiction.SerializeJson(writer, options);
      }

      writer.WritePropertyName("status");
      current.Status.SerializeJson(writer, options);

      writer.WritePropertyName("dateRange");
      current.DateRange.SerializeJson(writer, options);

      if ((current.RestoreDateElement != null) && (current.RestoreDateElement.Value != null))
      {
        writer.WriteString("restoreDate",current.RestoreDateElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MarketingStatus
    /// </summary>
    public static void DeserializeJson(this MarketingStatus current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR MarketingStatus
    /// </summary>
    public static void DeserializeJsonProperty(this MarketingStatus current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "country":
          current.Country = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "jurisdiction":
          current.Jurisdiction = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "status":
          current.Status = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "dateRange":
          current.DateRange = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);

          break;

        case "restoreDate":
          current.RestoreDateElement = new FhirDateTime(reader.GetString());

          break;

        // Complex: MarketingStatus, Export: MarketingStatus, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneType)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MarketingStatusJsonConverter : JsonConverter<MarketingStatus>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(MarketingStatus).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, MarketingStatus value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override MarketingStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        MarketingStatus target = new MarketingStatus();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
