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
  /// JSON Serialization Extensions for OperationOutcome
  /// </summary>
  public static class OperationOutcomeJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR OperationOutcome into JSON
    /// </summary>
    public static void SerializeJson(this OperationOutcome current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","OperationOutcome");
      // Complex: OperationOutcome, Export: OperationOutcome, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Issue != null) && (current.Issue.Count != 0))
      {
        writer.WritePropertyName("issue");
        writer.WriteStartArray();
        foreach (OperationOutcome.IssueComponent val in current.Issue)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR OperationOutcome
    /// </summary>
    public static void DeserializeJson(this OperationOutcome current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR OperationOutcome
    /// </summary>
    public static void DeserializeJsonProperty(this OperationOutcome current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "issue":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Issue = new List<OperationOutcome.IssueComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Issue.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.OperationOutcome.IssueComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Issue.Count == 0)
          {
            current.Issue = null;
          }

          break;

        // Complex: OperationOutcome, Export: OperationOutcome, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR OperationOutcome#Issue into JSON
    /// </summary>
    public static void SerializeJson(this OperationOutcome.IssueComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: OperationOutcome#Issue, Export: IssueComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("severity",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.SeverityElement.Value));

      writer.WriteString("code",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.CodeElement.Value));

      if (current.Details != null)
      {
        writer.WritePropertyName("details");
        current.Details.SerializeJson(writer, options);
      }

      if ((current.DiagnosticsElement != null) && (current.DiagnosticsElement.Value != null))
      {
        writer.WriteString("diagnostics",current.DiagnosticsElement.Value);
      }

      if ((current.LocationElement != null) && (current.LocationElement.Count != 0))
      {
        writer.WritePropertyName("location");
        writer.WriteStartArray();
        foreach (FhirString val in current.LocationElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if ((current.ExpressionElement != null) && (current.ExpressionElement.Count != 0))
      {
        writer.WritePropertyName("expression");
        writer.WriteStartArray();
        foreach (FhirString val in current.ExpressionElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR OperationOutcome#Issue
    /// </summary>
    public static void DeserializeJson(this OperationOutcome.IssueComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR OperationOutcome#Issue
    /// </summary>
    public static void DeserializeJsonProperty(this OperationOutcome.IssueComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "severity":
          current.SeverityElement =new Code<Hl7.Fhir.Model.OperationOutcome.IssueSeverity>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.OperationOutcome.IssueSeverity>(reader.GetString()));

          break;

        case "code":
          current.CodeElement =new Code<Hl7.Fhir.Model.OperationOutcome.IssueType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.OperationOutcome.IssueType>(reader.GetString()));

          break;

        case "details":
          current.Details = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "diagnostics":
          current.DiagnosticsElement = new FhirString(reader.GetString());

          break;

        case "location":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.LocationElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.LocationElement.Add(new FhirString(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.LocationElement.Count == 0)
          {
            current.LocationElement = null;
          }

          break;

        case "expression":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ExpressionElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ExpressionElement.Add(new FhirString(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ExpressionElement.Count == 0)
          {
            current.ExpressionElement = null;
          }

          break;

        // Complex: issue, Export: IssueComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class OperationOutcomeJsonConverter : JsonConverter<OperationOutcome>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(OperationOutcome).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, OperationOutcome value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override OperationOutcome Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        OperationOutcome target = new OperationOutcome();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
