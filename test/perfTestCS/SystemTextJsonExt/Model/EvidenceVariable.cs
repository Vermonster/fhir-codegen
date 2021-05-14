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
  /// JSON Serialization Extensions for EvidenceVariable
  /// </summary>
  public static class EvidenceVariableJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR EvidenceVariable into JSON
    /// </summary>
    public static void SerializeJson(this EvidenceVariable current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","EvidenceVariable");
      // Complex: EvidenceVariable, Export: EvidenceVariable, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.UrlElement != null) && (current.UrlElement.Value != null))
      {
        writer.WriteString("url",current.UrlElement.Value);
      }

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.VersionElement != null) && (current.VersionElement.Value != null))
      {
        writer.WriteString("version",current.VersionElement.Value);
      }

      if ((current.NameElement != null) && (current.NameElement.Value != null))
      {
        writer.WriteString("name",current.NameElement.Value);
      }

      if ((current.TitleElement != null) && (current.TitleElement.Value != null))
      {
        writer.WriteString("title",current.TitleElement.Value);
      }

      if ((current.ShortTitleElement != null) && (current.ShortTitleElement.Value != null))
      {
        writer.WriteString("shortTitle",current.ShortTitleElement.Value);
      }

      if ((current.SubtitleElement != null) && (current.SubtitleElement.Value != null))
      {
        writer.WriteString("subtitle",current.SubtitleElement.Value);
      }

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      if ((current.DateElement != null) && (current.DateElement.Value != null))
      {
        writer.WriteString("date",current.DateElement.Value);
      }

      if ((current.PublisherElement != null) && (current.PublisherElement.Value != null))
      {
        writer.WriteString("publisher",current.PublisherElement.Value);
      }

      if ((current.Contact != null) && (current.Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();
        foreach (ContactDetail val in current.Contact)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Description != null) && (current.Description.Value != null))
      {
        writer.WriteString("description",current.Description.Value);
      }

      if ((current.Note != null) && (current.Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();
        foreach (Annotation val in current.Note)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.UseContext != null) && (current.UseContext.Count != 0))
      {
        writer.WritePropertyName("useContext");
        writer.WriteStartArray();
        foreach (UsageContext val in current.UseContext)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Jurisdiction != null) && (current.Jurisdiction.Count != 0))
      {
        writer.WritePropertyName("jurisdiction");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Jurisdiction)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Copyright != null) && (current.Copyright.Value != null))
      {
        writer.WriteString("copyright",current.Copyright.Value);
      }

      if ((current.ApprovalDateElement != null) && (current.ApprovalDateElement.Value != null))
      {
        writer.WriteString("approvalDate",current.ApprovalDateElement.Value);
      }

      if ((current.LastReviewDateElement != null) && (current.LastReviewDateElement.Value != null))
      {
        writer.WriteString("lastReviewDate",current.LastReviewDateElement.Value);
      }

      if (current.EffectivePeriod != null)
      {
        writer.WritePropertyName("effectivePeriod");
        current.EffectivePeriod.SerializeJson(writer, options);
      }

      if ((current.Topic != null) && (current.Topic.Count != 0))
      {
        writer.WritePropertyName("topic");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Topic)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Author != null) && (current.Author.Count != 0))
      {
        writer.WritePropertyName("author");
        writer.WriteStartArray();
        foreach (ContactDetail val in current.Author)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Editor != null) && (current.Editor.Count != 0))
      {
        writer.WritePropertyName("editor");
        writer.WriteStartArray();
        foreach (ContactDetail val in current.Editor)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Reviewer != null) && (current.Reviewer.Count != 0))
      {
        writer.WritePropertyName("reviewer");
        writer.WriteStartArray();
        foreach (ContactDetail val in current.Reviewer)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Endorser != null) && (current.Endorser.Count != 0))
      {
        writer.WritePropertyName("endorser");
        writer.WriteStartArray();
        foreach (ContactDetail val in current.Endorser)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.RelatedArtifact != null) && (current.RelatedArtifact.Count != 0))
      {
        writer.WritePropertyName("relatedArtifact");
        writer.WriteStartArray();
        foreach (RelatedArtifact val in current.RelatedArtifact)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.TypeElement != null)
      {
        writer.WriteString("type",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.TypeElement.Value));
      }

      if ((current.Characteristic != null) && (current.Characteristic.Count != 0))
      {
        writer.WritePropertyName("characteristic");
        writer.WriteStartArray();
        foreach (EvidenceVariable.CharacteristicComponent val in current.Characteristic)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR EvidenceVariable
    /// </summary>
    public static void DeserializeJson(this EvidenceVariable current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR EvidenceVariable
    /// </summary>
    public static void DeserializeJsonProperty(this EvidenceVariable current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "url":
          current.UrlElement = new FhirUri(reader.GetString());

          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Identifier.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Identifier>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }

          break;

        case "version":
          current.VersionElement = new FhirString(reader.GetString());

          break;

        case "name":
          current.NameElement = new FhirString(reader.GetString());

          break;

        case "title":
          current.TitleElement = new FhirString(reader.GetString());

          break;

        case "shortTitle":
          current.ShortTitleElement = new FhirString(reader.GetString());

          break;

        case "subtitle":
          current.SubtitleElement = new FhirString(reader.GetString());

          break;

        case "status":
          current.StatusElement =new Code<Hl7.Fhir.Model.PublicationStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.PublicationStatus>(reader.GetString()));

          break;

        case "date":
          current.DateElement = new FhirDateTime(reader.GetString());

          break;

        case "publisher":
          current.PublisherElement = new FhirString(reader.GetString());

          break;

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Contact = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Contact.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ContactDetail>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Contact.Count == 0)
          {
            current.Contact = null;
          }

          break;

        case "description":
          current.Description = new Markdown(reader.GetString());

          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Note.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Annotation>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Note.Count == 0)
          {
            current.Note = null;
          }

          break;

        case "useContext":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.UseContext = new List<UsageContext>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.UseContext.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.UsageContext>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.UseContext.Count == 0)
          {
            current.UseContext = null;
          }

          break;

        case "jurisdiction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Jurisdiction = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Jurisdiction.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Jurisdiction.Count == 0)
          {
            current.Jurisdiction = null;
          }

          break;

        case "copyright":
          current.Copyright = new Markdown(reader.GetString());

          break;

        case "approvalDate":
          current.ApprovalDateElement = new Date(reader.GetString());

          break;

        case "lastReviewDate":
          current.LastReviewDateElement = new Date(reader.GetString());

          break;

        case "effectivePeriod":
          current.EffectivePeriod = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);

          break;

        case "topic":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Topic = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Topic.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Topic.Count == 0)
          {
            current.Topic = null;
          }

          break;

        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Author = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Author.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ContactDetail>(ref reader, options));

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

        case "editor":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Editor = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Editor.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ContactDetail>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Editor.Count == 0)
          {
            current.Editor = null;
          }

          break;

        case "reviewer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Reviewer = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Reviewer.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ContactDetail>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Reviewer.Count == 0)
          {
            current.Reviewer = null;
          }

          break;

        case "endorser":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Endorser = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Endorser.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ContactDetail>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Endorser.Count == 0)
          {
            current.Endorser = null;
          }

          break;

        case "relatedArtifact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.RelatedArtifact = new List<RelatedArtifact>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.RelatedArtifact.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.RelatedArtifact>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.RelatedArtifact.Count == 0)
          {
            current.RelatedArtifact = null;
          }

          break;

        case "type":
          current.TypeElement =new Code<Hl7.Fhir.Model.EvidenceVariableType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.EvidenceVariableType>(reader.GetString()));

          break;

        case "characteristic":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Characteristic = new List<EvidenceVariable.CharacteristicComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Characteristic.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.EvidenceVariable.CharacteristicComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Characteristic.Count == 0)
          {
            current.Characteristic = null;
          }

          break;

        // Complex: EvidenceVariable, Export: EvidenceVariable, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR EvidenceVariable#Characteristic into JSON
    /// </summary>
    public static void SerializeJson(this EvidenceVariable.CharacteristicComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: EvidenceVariable#Characteristic, Export: CharacteristicComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.DescriptionElement != null) && (current.DescriptionElement.Value != null))
      {
        writer.WriteString("description",current.DescriptionElement.Value);
      }

      if (current.Definition != null)
      {
        switch (current.Definition)
        {
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("definitionReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
          case Canonical v_Canonical:
            writer.WriteString("definitionCanonical",v_Canonical.Value);
            break;
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("definitionCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case Expression v_Expression:
            writer.WritePropertyName("definitionExpression");
            v_Expression.SerializeJson(writer, options);
            break;
          case DataRequirement v_DataRequirement:
            writer.WritePropertyName("definitionDataRequirement");
            v_DataRequirement.SerializeJson(writer, options);
            break;
          case TriggerDefinition v_TriggerDefinition:
            writer.WritePropertyName("definitionTriggerDefinition");
            v_TriggerDefinition.SerializeJson(writer, options);
            break;
        }
      }
      if ((current.UsageContext != null) && (current.UsageContext.Count != 0))
      {
        writer.WritePropertyName("usageContext");
        writer.WriteStartArray();
        foreach (UsageContext val in current.UsageContext)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ExcludeElement != null) && (current.ExcludeElement.Value != null))
      {
        writer.WriteBoolean("exclude",(bool)current.ExcludeElement.Value);
      }

      if (current.ParticipantEffective != null)
      {
        switch (current.ParticipantEffective)
        {
          case FhirDateTime v_FhirDateTime:
            writer.WriteString("participantEffectiveDateTime",v_FhirDateTime.Value);
            break;
          case Period v_Period:
            writer.WritePropertyName("participantEffectivePeriod");
            v_Period.SerializeJson(writer, options);
            break;
          case Duration v_Duration:
            writer.WritePropertyName("participantEffectiveDuration");
            v_Duration.SerializeJson(writer, options);
            break;
          case Timing v_Timing:
            writer.WritePropertyName("participantEffectiveTiming");
            v_Timing.SerializeJson(writer, options);
            break;
        }
      }
      if (current.TimeFromStart != null)
      {
        writer.WritePropertyName("timeFromStart");
        current.TimeFromStart.SerializeJson(writer, options);
      }

      if (current.GroupMeasureElement != null)
      {
        writer.WriteString("groupMeasure",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.GroupMeasureElement.Value));
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR EvidenceVariable#Characteristic
    /// </summary>
    public static void DeserializeJson(this EvidenceVariable.CharacteristicComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR EvidenceVariable#Characteristic
    /// </summary>
    public static void DeserializeJsonProperty(this EvidenceVariable.CharacteristicComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "description":
          current.DescriptionElement = new FhirString(reader.GetString());

          break;

        case "definitionReference":
          current.Definition = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);
          break;

        case "definitionCanonical":
          current.Definition = new Canonical(reader.GetString());
          break;

        case "definitionCodeableConcept":
          current.Definition = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);
          break;

        case "definitionExpression":
          current.Definition = JsonSerializer.Deserialize<Hl7.Fhir.Model.Expression>(ref reader, options);
          break;

        case "definitionDataRequirement":
          current.Definition = JsonSerializer.Deserialize<Hl7.Fhir.Model.DataRequirement>(ref reader, options);
          break;

        case "definitionTriggerDefinition":
          current.Definition = JsonSerializer.Deserialize<Hl7.Fhir.Model.TriggerDefinition>(ref reader, options);
          break;

        case "usageContext":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.UsageContext = new List<UsageContext>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.UsageContext.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.UsageContext>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.UsageContext.Count == 0)
          {
            current.UsageContext = null;
          }

          break;

        case "exclude":
          current.ExcludeElement = new FhirBoolean(reader.GetBoolean());

          break;

        case "participantEffectiveDateTime":
          current.ParticipantEffective = new FhirDateTime(reader.GetString());
          break;

        case "participantEffectivePeriod":
          current.ParticipantEffective = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);
          break;

        case "participantEffectiveDuration":
          current.ParticipantEffective = JsonSerializer.Deserialize<Hl7.Fhir.Model.Duration>(ref reader, options);
          break;

        case "participantEffectiveTiming":
          current.ParticipantEffective = JsonSerializer.Deserialize<Hl7.Fhir.Model.Timing>(ref reader, options);
          break;

        case "timeFromStart":
          current.TimeFromStart = JsonSerializer.Deserialize<Hl7.Fhir.Model.Duration>(ref reader, options);

          break;

        case "groupMeasure":
          current.GroupMeasureElement =new Code<Hl7.Fhir.Model.GroupMeasure>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.GroupMeasure>(reader.GetString()));

          break;

        // Complex: characteristic, Export: CharacteristicComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class EvidenceVariableJsonConverter : JsonConverter<EvidenceVariable>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(EvidenceVariable).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, EvidenceVariable value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override EvidenceVariable Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        EvidenceVariable target = new EvidenceVariable();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
