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
  /// JSON Serialization Extensions for AdverseEvent
  /// </summary>
  public static class AdverseEventJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR AdverseEvent into JSON
    /// </summary>
    public static void SerializeJson(this AdverseEvent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","AdverseEvent");
      // Complex: AdverseEvent, Export: AdverseEvent, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if (current.Identifier != null)
      {
        writer.WritePropertyName("identifier");
        current.Identifier.SerializeJson(writer, options);
      }

      writer.WriteString("actuality",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.ActualityElement.Value));

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

      if (current.Event != null)
      {
        writer.WritePropertyName("event");
        current.Event.SerializeJson(writer, options);
      }

      writer.WritePropertyName("subject");
      current.Subject.SerializeJson(writer, options);

      if (current.Encounter != null)
      {
        writer.WritePropertyName("encounter");
        current.Encounter.SerializeJson(writer, options);
      }

      if ((current.DateElement != null) && (current.DateElement.Value != null))
      {
        writer.WriteString("date",current.DateElement.Value);
      }

      if ((current.DetectedElement != null) && (current.DetectedElement.Value != null))
      {
        writer.WriteString("detected",current.DetectedElement.Value);
      }

      if ((current.RecordedDateElement != null) && (current.RecordedDateElement.Value != null))
      {
        writer.WriteString("recordedDate",current.RecordedDateElement.Value);
      }

      if ((current.ResultingCondition != null) && (current.ResultingCondition.Count != 0))
      {
        writer.WritePropertyName("resultingCondition");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.ResultingCondition)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Location != null)
      {
        writer.WritePropertyName("location");
        current.Location.SerializeJson(writer, options);
      }

      if (current.Seriousness != null)
      {
        writer.WritePropertyName("seriousness");
        current.Seriousness.SerializeJson(writer, options);
      }

      if (current.Severity != null)
      {
        writer.WritePropertyName("severity");
        current.Severity.SerializeJson(writer, options);
      }

      if (current.Outcome != null)
      {
        writer.WritePropertyName("outcome");
        current.Outcome.SerializeJson(writer, options);
      }

      if (current.Recorder != null)
      {
        writer.WritePropertyName("recorder");
        current.Recorder.SerializeJson(writer, options);
      }

      if ((current.Contributor != null) && (current.Contributor.Count != 0))
      {
        writer.WritePropertyName("contributor");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Contributor)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.SuspectEntity != null) && (current.SuspectEntity.Count != 0))
      {
        writer.WritePropertyName("suspectEntity");
        writer.WriteStartArray();
        foreach (AdverseEvent.SuspectEntityComponent val in current.SuspectEntity)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.SubjectMedicalHistory != null) && (current.SubjectMedicalHistory.Count != 0))
      {
        writer.WritePropertyName("subjectMedicalHistory");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.SubjectMedicalHistory)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ReferenceDocument != null) && (current.ReferenceDocument.Count != 0))
      {
        writer.WritePropertyName("referenceDocument");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.ReferenceDocument)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Study != null) && (current.Study.Count != 0))
      {
        writer.WritePropertyName("study");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Study)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR AdverseEvent
    /// </summary>
    public static void DeserializeJson(this AdverseEvent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR AdverseEvent
    /// </summary>
    public static void DeserializeJsonProperty(this AdverseEvent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          current.Identifier = JsonSerializer.Deserialize<Hl7.Fhir.Model.Identifier>(ref reader, options);

          break;

        case "actuality":
          current.ActualityElement =new Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality>(reader.GetString()));

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

        case "event":
          current.Event = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

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

        case "detected":
          current.DetectedElement = new FhirDateTime(reader.GetString());

          break;

        case "recordedDate":
          current.RecordedDateElement = new FhirDateTime(reader.GetString());

          break;

        case "resultingCondition":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ResultingCondition = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ResultingCondition.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ResultingCondition.Count == 0)
          {
            current.ResultingCondition = null;
          }

          break;

        case "location":
          current.Location = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "seriousness":
          current.Seriousness = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "severity":
          current.Severity = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "outcome":
          current.Outcome = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "recorder":
          current.Recorder = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "contributor":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Contributor = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Contributor.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Contributor.Count == 0)
          {
            current.Contributor = null;
          }

          break;

        case "suspectEntity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.SuspectEntity = new List<AdverseEvent.SuspectEntityComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.SuspectEntity.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.AdverseEvent.SuspectEntityComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.SuspectEntity.Count == 0)
          {
            current.SuspectEntity = null;
          }

          break;

        case "subjectMedicalHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.SubjectMedicalHistory = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.SubjectMedicalHistory.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.SubjectMedicalHistory.Count == 0)
          {
            current.SubjectMedicalHistory = null;
          }

          break;

        case "referenceDocument":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ReferenceDocument = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ReferenceDocument.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ReferenceDocument.Count == 0)
          {
            current.ReferenceDocument = null;
          }

          break;

        case "study":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Study = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Study.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Study.Count == 0)
          {
            current.Study = null;
          }

          break;

        // Complex: AdverseEvent, Export: AdverseEvent, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR AdverseEvent#SuspectEntity into JSON
    /// </summary>
    public static void SerializeJson(this AdverseEvent.SuspectEntityComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: AdverseEvent#SuspectEntity, Export: SuspectEntityComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("instance");
      current.Instance.SerializeJson(writer, options);

      if ((current.Causality != null) && (current.Causality.Count != 0))
      {
        writer.WritePropertyName("causality");
        writer.WriteStartArray();
        foreach (AdverseEvent.CausalityComponent val in current.Causality)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR AdverseEvent#SuspectEntity
    /// </summary>
    public static void DeserializeJson(this AdverseEvent.SuspectEntityComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR AdverseEvent#SuspectEntity
    /// </summary>
    public static void DeserializeJsonProperty(this AdverseEvent.SuspectEntityComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "instance":
          current.Instance = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "causality":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Causality = new List<AdverseEvent.CausalityComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Causality.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.AdverseEvent.CausalityComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Causality.Count == 0)
          {
            current.Causality = null;
          }

          break;

        // Complex: suspectEntity, Export: SuspectEntityComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR AdverseEvent#Causality into JSON
    /// </summary>
    public static void SerializeJson(this AdverseEvent.CausalityComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: AdverseEvent#Causality, Export: CausalityComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Assessment != null)
      {
        writer.WritePropertyName("assessment");
        current.Assessment.SerializeJson(writer, options);
      }

      if ((current.ProductRelatednessElement != null) && (current.ProductRelatednessElement.Value != null))
      {
        writer.WriteString("productRelatedness",current.ProductRelatednessElement.Value);
      }

      if (current.Author != null)
      {
        writer.WritePropertyName("author");
        current.Author.SerializeJson(writer, options);
      }

      if (current.Method != null)
      {
        writer.WritePropertyName("method");
        current.Method.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR AdverseEvent#Causality
    /// </summary>
    public static void DeserializeJson(this AdverseEvent.CausalityComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR AdverseEvent#Causality
    /// </summary>
    public static void DeserializeJsonProperty(this AdverseEvent.CausalityComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "assessment":
          current.Assessment = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "productRelatedness":
          current.ProductRelatednessElement = new FhirString(reader.GetString());

          break;

        case "author":
          current.Author = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "method":
          current.Method = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        // Complex: causality, Export: CausalityComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class AdverseEventJsonConverter : JsonConverter<AdverseEvent>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(AdverseEvent).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, AdverseEvent value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override AdverseEvent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        AdverseEvent target = new AdverseEvent();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
