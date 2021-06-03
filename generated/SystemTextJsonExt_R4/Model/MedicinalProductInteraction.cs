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
  /// JSON Serialization Extensions for MedicinalProductInteraction
  /// </summary>
  public static class MedicinalProductInteractionJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR MedicinalProductInteraction into JSON
    /// </summary>
    public static void SerializeJson(this MedicinalProductInteraction current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","MedicinalProductInteraction");
      // Complex: MedicinalProductInteraction, Export: MedicinalProductInteraction, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Subject != null) && (current.Subject.Count != 0))
      {
        writer.WritePropertyName("subject");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Subject)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.DescriptionElement != null)
      {
        if (!string.IsNullOrEmpty(current.DescriptionElement.Value))
        {
          writer.WriteString("description",current.DescriptionElement.Value);
        }
        if (current.DescriptionElement.HasExtensions() || (!string.IsNullOrEmpty(current.DescriptionElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_description",false,current.DescriptionElement.Extension,current.DescriptionElement.ElementId);
        }
      }

      if ((current.Interactant != null) && (current.Interactant.Count != 0))
      {
        writer.WritePropertyName("interactant");
        writer.WriteStartArray();
        foreach (MedicinalProductInteraction.InteractantComponent val in current.Interactant)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Type != null)
      {
        writer.WritePropertyName("type");
        current.Type.SerializeJson(writer, options);
      }

      if (current.Effect != null)
      {
        writer.WritePropertyName("effect");
        current.Effect.SerializeJson(writer, options);
      }

      if (current.Incidence != null)
      {
        writer.WritePropertyName("incidence");
        current.Incidence.SerializeJson(writer, options);
      }

      if (current.Management != null)
      {
        writer.WritePropertyName("management");
        current.Management.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductInteraction
    /// </summary>
    public static void DeserializeJson(this MedicinalProductInteraction current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicinalProductInteraction >>> MedicinalProductInteraction.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicinalProductInteraction: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductInteraction
    /// </summary>
    public static void DeserializeJsonProperty(this MedicinalProductInteraction current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "subject":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductInteraction error reading 'subject' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Subject = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Subject = new Hl7.Fhir.Model.ResourceReference();
            v_Subject.DeserializeJson(ref reader, options);
            current.Subject.Add(v_Subject);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductInteraction error reading 'subject' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Subject.Count == 0)
          {
            current.Subject = null;
          }
          break;

        case "description":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DescriptionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DescriptionElement = new FhirString(reader.GetString());
          }
          break;

        case "_description":
          if (current.DescriptionElement == null) { current.DescriptionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DescriptionElement).DeserializeJson(ref reader, options);
          break;

        case "interactant":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductInteraction error reading 'interactant' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Interactant = new List<MedicinalProductInteraction.InteractantComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.MedicinalProductInteraction.InteractantComponent v_Interactant = new Hl7.Fhir.Model.MedicinalProductInteraction.InteractantComponent();
            v_Interactant.DeserializeJson(ref reader, options);
            current.Interactant.Add(v_Interactant);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductInteraction error reading 'interactant' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Interactant.Count == 0)
          {
            current.Interactant = null;
          }
          break;

        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Type).DeserializeJson(ref reader, options);
          break;

        case "effect":
          current.Effect = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Effect).DeserializeJson(ref reader, options);
          break;

        case "incidence":
          current.Incidence = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Incidence).DeserializeJson(ref reader, options);
          break;

        case "management":
          current.Management = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Management).DeserializeJson(ref reader, options);
          break;

        // Complex: MedicinalProductInteraction, Export: MedicinalProductInteraction, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicinalProductInteraction#Interactant into JSON
    /// </summary>
    public static void SerializeJson(this MedicinalProductInteraction.InteractantComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicinalProductInteraction#Interactant, Export: InteractantComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Item != null)
      {
        switch (current.Item)
        {
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("itemReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("itemCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductInteraction#Interactant
    /// </summary>
    public static void DeserializeJson(this MedicinalProductInteraction.InteractantComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicinalProductInteraction.InteractantComponent >>> MedicinalProductInteraction#Interactant.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicinalProductInteraction.InteractantComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductInteraction#Interactant
    /// </summary>
    public static void DeserializeJsonProperty(this MedicinalProductInteraction.InteractantComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "itemReference":
          current.Item = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Item).DeserializeJson(ref reader, options);
          break;

        case "itemCodeableConcept":
          current.Item = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Item).DeserializeJson(ref reader, options);
          break;

        // Complex: interactant, Export: InteractantComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MedicinalProductInteractionJsonConverter : JsonConverter<MedicinalProductInteraction>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, MedicinalProductInteraction value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override MedicinalProductInteraction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        MedicinalProductInteraction target = new MedicinalProductInteraction();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
