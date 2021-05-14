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
  /// JSON Serialization Extensions for Composition
  /// </summary>
  public static class CompositionJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Composition into JSON
    /// </summary>
    public static void SerializeJson(this Composition current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Composition");
      // Complex: Composition, Export: Composition, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if (current.Identifier != null)
      {
        writer.WritePropertyName("identifier");
        current.Identifier.SerializeJson(writer, options);
      }

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      writer.WritePropertyName("type");
      current.Type.SerializeJson(writer, options);

      if ((current.Category != null) && (current.Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Category)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Subject != null)
      {
        writer.WritePropertyName("subject");
        current.Subject.SerializeJson(writer, options);
      }

      if (current.Encounter != null)
      {
        writer.WritePropertyName("encounter");
        current.Encounter.SerializeJson(writer, options);
      }

      writer.WriteString("date",current.DateElement.Value);

      if ((current.Author != null) && (current.Author.Count != 0))
      {
        writer.WritePropertyName("author");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Author)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WriteString("title",current.TitleElement.Value);

      if (current.ConfidentialityElement != null)
      {
        writer.WriteString("confidentiality",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.ConfidentialityElement.Value));
      }

      if ((current.Attester != null) && (current.Attester.Count != 0))
      {
        writer.WritePropertyName("attester");
        writer.WriteStartArray();
        foreach (Composition.AttesterComponent val in current.Attester)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Custodian != null)
      {
        writer.WritePropertyName("custodian");
        current.Custodian.SerializeJson(writer, options);
      }

      if ((current.RelatesTo != null) && (current.RelatesTo.Count != 0))
      {
        writer.WritePropertyName("relatesTo");
        writer.WriteStartArray();
        foreach (Composition.RelatesToComponent val in current.RelatesTo)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Event != null) && (current.Event.Count != 0))
      {
        writer.WritePropertyName("event");
        writer.WriteStartArray();
        foreach (Composition.EventComponent val in current.Event)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Section != null) && (current.Section.Count != 0))
      {
        writer.WritePropertyName("section");
        writer.WriteStartArray();
        foreach (Composition.SectionComponent val in current.Section)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition
    /// </summary>
    public static void DeserializeJson(this Composition current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Composition
    /// </summary>
    public static void DeserializeJsonProperty(this Composition current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          current.Identifier = JsonSerializer.Deserialize<Hl7.Fhir.Model.Identifier>(ref reader, options);

          break;

        case "status":
          current.StatusElement =new Code<Hl7.Fhir.Model.CompositionStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.CompositionStatus>(reader.GetString()));

          break;

        case "type":
          current.Type = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Category.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Category.Count == 0)
          {
            current.Category = null;
          }

          break;

        case "subject":
          current.Subject = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "encounter":
          current.Encounter = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "date":
          current.DateElement = new FhirDateTime(reader.GetString());

          break;

        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Author = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Author.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Author.Count == 0)
          {
            current.Author = null;
          }

          break;

        case "title":
          current.TitleElement = new FhirString(reader.GetString());

          break;

        case "confidentiality":
          current.ConfidentialityElement =new Code<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification>(reader.GetString()));

          break;

        case "attester":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Attester = new List<Composition.AttesterComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Attester.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Composition.AttesterComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Attester.Count == 0)
          {
            current.Attester = null;
          }

          break;

        case "custodian":
          current.Custodian = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "relatesTo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.RelatesTo = new List<Composition.RelatesToComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.RelatesTo.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Composition.RelatesToComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.RelatesTo.Count == 0)
          {
            current.RelatesTo = null;
          }

          break;

        case "event":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Event = new List<Composition.EventComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Event.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Composition.EventComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Event.Count == 0)
          {
            current.Event = null;
          }

          break;

        case "section":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Section = new List<Composition.SectionComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Section.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Composition.SectionComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Section.Count == 0)
          {
            current.Section = null;
          }

          break;

        // Complex: Composition, Export: Composition, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Composition#Attester into JSON
    /// </summary>
    public static void SerializeJson(this Composition.AttesterComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Composition#Attester, Export: AttesterComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("mode",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.ModeElement.Value));

      if ((current.TimeElement != null) && (current.TimeElement.Value != null))
      {
        writer.WriteString("time",current.TimeElement.Value);
      }

      if (current.Party != null)
      {
        writer.WritePropertyName("party");
        current.Party.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#Attester
    /// </summary>
    public static void DeserializeJson(this Composition.AttesterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Composition#Attester
    /// </summary>
    public static void DeserializeJsonProperty(this Composition.AttesterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "mode":
          current.ModeElement =new Code<Hl7.Fhir.Model.Composition.CompositionAttestationMode>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Composition.CompositionAttestationMode>(reader.GetString()));

          break;

        case "time":
          current.TimeElement = new FhirDateTime(reader.GetString());

          break;

        case "party":
          current.Party = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        // Complex: attester, Export: AttesterComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Composition#RelatesTo into JSON
    /// </summary>
    public static void SerializeJson(this Composition.RelatesToComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Composition#RelatesTo, Export: RelatesToComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("code",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.CodeElement.Value));

      if (current.Target != null)
      {
        switch (current.Target)
        {
          case Identifier v_Identifier:
            writer.WritePropertyName("targetIdentifier");
            v_Identifier.SerializeJson(writer, options);
            break;
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("targetReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#RelatesTo
    /// </summary>
    public static void DeserializeJson(this Composition.RelatesToComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Composition#RelatesTo
    /// </summary>
    public static void DeserializeJsonProperty(this Composition.RelatesToComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          current.CodeElement =new Code<Hl7.Fhir.Model.DocumentRelationshipType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.DocumentRelationshipType>(reader.GetString()));

          break;

        case "targetIdentifier":
          current.Target = JsonSerializer.Deserialize<Hl7.Fhir.Model.Identifier>(ref reader, options);
          break;

        case "targetReference":
          current.Target = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);
          break;

        // Complex: relatesTo, Export: RelatesToComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Composition#Event into JSON
    /// </summary>
    public static void SerializeJson(this Composition.EventComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Composition#Event, Export: EventComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.Code != null) && (current.Code.Count != 0))
      {
        writer.WritePropertyName("code");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Code)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Period != null)
      {
        writer.WritePropertyName("period");
        current.Period.SerializeJson(writer, options);
      }

      if ((current.Detail != null) && (current.Detail.Count != 0))
      {
        writer.WritePropertyName("detail");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Detail)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#Event
    /// </summary>
    public static void DeserializeJson(this Composition.EventComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Composition#Event
    /// </summary>
    public static void DeserializeJsonProperty(this Composition.EventComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Code = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Code.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Code.Count == 0)
          {
            current.Code = null;
          }

          break;

        case "period":
          current.Period = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);

          break;

        case "detail":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Detail = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Detail.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Detail.Count == 0)
          {
            current.Detail = null;
          }

          break;

        // Complex: event, Export: EventComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Composition#Section into JSON
    /// </summary>
    public static void SerializeJson(this Composition.SectionComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Composition#Section, Export: SectionComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.TitleElement != null) && (current.TitleElement.Value != null))
      {
        writer.WriteString("title",current.TitleElement.Value);
      }

      if (current.Code != null)
      {
        writer.WritePropertyName("code");
        current.Code.SerializeJson(writer, options);
      }

      if ((current.Author != null) && (current.Author.Count != 0))
      {
        writer.WritePropertyName("author");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Author)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Focus != null)
      {
        writer.WritePropertyName("focus");
        current.Focus.SerializeJson(writer, options);
      }

      if (current.Text != null)
      {
        writer.WritePropertyName("text");
        current.Text.SerializeJson(writer, options);
      }

      if (current.ModeElement != null)
      {
        writer.WriteString("mode",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.ModeElement.Value));
      }

      if (current.OrderedBy != null)
      {
        writer.WritePropertyName("orderedBy");
        current.OrderedBy.SerializeJson(writer, options);
      }

      if ((current.Entry != null) && (current.Entry.Count != 0))
      {
        writer.WritePropertyName("entry");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Entry)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.EmptyReason != null)
      {
        writer.WritePropertyName("emptyReason");
        current.EmptyReason.SerializeJson(writer, options);
      }

      if ((current.Section != null) && (current.Section.Count != 0))
      {
        writer.WritePropertyName("section");
        writer.WriteStartArray();
        foreach (Composition.SectionComponent val in current.Section)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#Section
    /// </summary>
    public static void DeserializeJson(this Composition.SectionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Composition#Section
    /// </summary>
    public static void DeserializeJsonProperty(this Composition.SectionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "title":
          current.TitleElement = new FhirString(reader.GetString());

          break;

        case "code":
          current.Code = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Author = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Author.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Author.Count == 0)
          {
            current.Author = null;
          }

          break;

        case "focus":
          current.Focus = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "text":
          current.Text = JsonSerializer.Deserialize<Hl7.Fhir.Model.Narrative>(ref reader, options);

          break;

        case "mode":
          current.ModeElement =new Code<Hl7.Fhir.Model.ListMode>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ListMode>(reader.GetString()));

          break;

        case "orderedBy":
          current.OrderedBy = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "entry":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Entry = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Entry.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Entry.Count == 0)
          {
            current.Entry = null;
          }

          break;

        case "emptyReason":
          current.EmptyReason = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "section":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Section = new List<Composition.SectionComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Section.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Composition.SectionComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Section.Count == 0)
          {
            current.Section = null;
          }

          break;

        // Complex: section, Export: SectionComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class CompositionJsonConverter : JsonConverter<Composition>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(Composition).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Composition value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Composition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Composition target = new Composition();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
