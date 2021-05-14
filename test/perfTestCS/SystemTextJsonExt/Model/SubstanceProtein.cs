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
  /// JSON Serialization Extensions for SubstanceProtein
  /// </summary>
  public static class SubstanceProteinJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR SubstanceProtein into JSON
    /// </summary>
    public static void SerializeJson(this SubstanceProtein current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","SubstanceProtein");
      // Complex: SubstanceProtein, Export: SubstanceProtein, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if (current.SequenceType != null)
      {
        writer.WritePropertyName("sequenceType");
        current.SequenceType.SerializeJson(writer, options);
      }

      if ((current.NumberOfSubunitsElement != null) && (current.NumberOfSubunitsElement.Value != null))
      {
        writer.WriteNumber("numberOfSubunits",(int)current.NumberOfSubunitsElement.Value);
      }

      if ((current.DisulfideLinkageElement != null) && (current.DisulfideLinkageElement.Count != 0))
      {
        writer.WritePropertyName("disulfideLinkage");
        writer.WriteStartArray();
        foreach (FhirString val in current.DisulfideLinkageElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if ((current.Subunit != null) && (current.Subunit.Count != 0))
      {
        writer.WritePropertyName("subunit");
        writer.WriteStartArray();
        foreach (SubstanceProtein.SubunitComponent val in current.Subunit)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceProtein
    /// </summary>
    public static void DeserializeJson(this SubstanceProtein current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SubstanceProtein
    /// </summary>
    public static void DeserializeJsonProperty(this SubstanceProtein current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "sequenceType":
          current.SequenceType = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "numberOfSubunits":
          current.NumberOfSubunitsElement = new Integer(reader.GetInt32());

          break;

        case "disulfideLinkage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.DisulfideLinkageElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.DisulfideLinkageElement.Add(new FhirString(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.DisulfideLinkageElement.Count == 0)
          {
            current.DisulfideLinkageElement = null;
          }

          break;

        case "subunit":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Subunit = new List<SubstanceProtein.SubunitComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Subunit.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.SubstanceProtein.SubunitComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Subunit.Count == 0)
          {
            current.Subunit = null;
          }

          break;

        // Complex: SubstanceProtein, Export: SubstanceProtein, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstanceProtein#Subunit into JSON
    /// </summary>
    public static void SerializeJson(this SubstanceProtein.SubunitComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstanceProtein#Subunit, Export: SubunitComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.SubunitElement != null) && (current.SubunitElement.Value != null))
      {
        writer.WriteNumber("subunit",(int)current.SubunitElement.Value);
      }

      if ((current.SequenceElement != null) && (current.SequenceElement.Value != null))
      {
        writer.WriteString("sequence",current.SequenceElement.Value);
      }

      if ((current.LengthElement != null) && (current.LengthElement.Value != null))
      {
        writer.WriteNumber("length",(int)current.LengthElement.Value);
      }

      if (current.SequenceAttachment != null)
      {
        writer.WritePropertyName("sequenceAttachment");
        current.SequenceAttachment.SerializeJson(writer, options);
      }

      if (current.NTerminalModificationId != null)
      {
        writer.WritePropertyName("nTerminalModificationId");
        current.NTerminalModificationId.SerializeJson(writer, options);
      }

      if ((current.NTerminalModificationElement != null) && (current.NTerminalModificationElement.Value != null))
      {
        writer.WriteString("nTerminalModification",current.NTerminalModificationElement.Value);
      }

      if (current.CTerminalModificationId != null)
      {
        writer.WritePropertyName("cTerminalModificationId");
        current.CTerminalModificationId.SerializeJson(writer, options);
      }

      if ((current.CTerminalModificationElement != null) && (current.CTerminalModificationElement.Value != null))
      {
        writer.WriteString("cTerminalModification",current.CTerminalModificationElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceProtein#Subunit
    /// </summary>
    public static void DeserializeJson(this SubstanceProtein.SubunitComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SubstanceProtein#Subunit
    /// </summary>
    public static void DeserializeJsonProperty(this SubstanceProtein.SubunitComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "subunit":
          current.SubunitElement = new Integer(reader.GetInt32());

          break;

        case "sequence":
          current.SequenceElement = new FhirString(reader.GetString());

          break;

        case "length":
          current.LengthElement = new Integer(reader.GetInt32());

          break;

        case "sequenceAttachment":
          current.SequenceAttachment = JsonSerializer.Deserialize<Hl7.Fhir.Model.Attachment>(ref reader, options);

          break;

        case "nTerminalModificationId":
          current.NTerminalModificationId = JsonSerializer.Deserialize<Hl7.Fhir.Model.Identifier>(ref reader, options);

          break;

        case "nTerminalModification":
          current.NTerminalModificationElement = new FhirString(reader.GetString());

          break;

        case "cTerminalModificationId":
          current.CTerminalModificationId = JsonSerializer.Deserialize<Hl7.Fhir.Model.Identifier>(ref reader, options);

          break;

        case "cTerminalModification":
          current.CTerminalModificationElement = new FhirString(reader.GetString());

          break;

        // Complex: subunit, Export: SubunitComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SubstanceProteinJsonConverter : JsonConverter<SubstanceProtein>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(SubstanceProtein).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, SubstanceProtein value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override SubstanceProtein Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        SubstanceProtein target = new SubstanceProtein();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
