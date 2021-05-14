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
  /// JSON Serialization Extensions for CarePlan
  /// </summary>
  public static class CarePlanJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR CarePlan into JSON
    /// </summary>
    public static void SerializeJson(this CarePlan current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","CarePlan");
      // Complex: CarePlan, Export: CarePlan, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

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

      if ((current.InstantiatesCanonicalElement != null) && (current.InstantiatesCanonicalElement.Count != 0))
      {
        writer.WritePropertyName("instantiatesCanonical");
        writer.WriteStartArray();
        foreach (Canonical val in current.InstantiatesCanonicalElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if ((current.InstantiatesUriElement != null) && (current.InstantiatesUriElement.Count != 0))
      {
        writer.WritePropertyName("instantiatesUri");
        writer.WriteStartArray();
        foreach (FhirUri val in current.InstantiatesUriElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if ((current.BasedOn != null) && (current.BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.BasedOn)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Replaces != null) && (current.Replaces.Count != 0))
      {
        writer.WritePropertyName("replaces");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Replaces)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.PartOf != null) && (current.PartOf.Count != 0))
      {
        writer.WritePropertyName("partOf");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.PartOf)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      writer.WriteString("intent",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.IntentElement.Value));

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

      if ((current.TitleElement != null) && (current.TitleElement.Value != null))
      {
        writer.WriteString("title",current.TitleElement.Value);
      }

      if ((current.DescriptionElement != null) && (current.DescriptionElement.Value != null))
      {
        writer.WriteString("description",current.DescriptionElement.Value);
      }

      writer.WritePropertyName("subject");
      current.Subject.SerializeJson(writer, options);

      if (current.Encounter != null)
      {
        writer.WritePropertyName("encounter");
        current.Encounter.SerializeJson(writer, options);
      }

      if (current.Period != null)
      {
        writer.WritePropertyName("period");
        current.Period.SerializeJson(writer, options);
      }

      if ((current.CreatedElement != null) && (current.CreatedElement.Value != null))
      {
        writer.WriteString("created",current.CreatedElement.Value);
      }

      if (current.Author != null)
      {
        writer.WritePropertyName("author");
        current.Author.SerializeJson(writer, options);
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

      if ((current.CareTeam != null) && (current.CareTeam.Count != 0))
      {
        writer.WritePropertyName("careTeam");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.CareTeam)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Addresses != null) && (current.Addresses.Count != 0))
      {
        writer.WritePropertyName("addresses");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Addresses)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.SupportingInfo != null) && (current.SupportingInfo.Count != 0))
      {
        writer.WritePropertyName("supportingInfo");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.SupportingInfo)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Goal != null) && (current.Goal.Count != 0))
      {
        writer.WritePropertyName("goal");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Goal)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Activity != null) && (current.Activity.Count != 0))
      {
        writer.WritePropertyName("activity");
        writer.WriteStartArray();
        foreach (CarePlan.ActivityComponent val in current.Activity)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
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

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CarePlan
    /// </summary>
    public static void DeserializeJson(this CarePlan current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR CarePlan
    /// </summary>
    public static void DeserializeJsonProperty(this CarePlan current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
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

        case "instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.InstantiatesCanonicalElement = new List<Canonical>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.InstantiatesCanonicalElement.Add(new Canonical(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.InstantiatesCanonicalElement.Count == 0)
          {
            current.InstantiatesCanonicalElement = null;
          }

          break;

        case "instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.InstantiatesUriElement = new List<FhirUri>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.InstantiatesUriElement.Add(new FhirUri(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.InstantiatesUriElement.Count == 0)
          {
            current.InstantiatesUriElement = null;
          }

          break;

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.BasedOn = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.BasedOn.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.BasedOn.Count == 0)
          {
            current.BasedOn = null;
          }

          break;

        case "replaces":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Replaces = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Replaces.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Replaces.Count == 0)
          {
            current.Replaces = null;
          }

          break;

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.PartOf = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.PartOf.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.PartOf.Count == 0)
          {
            current.PartOf = null;
          }

          break;

        case "status":
          current.StatusElement =new Code<Hl7.Fhir.Model.RequestStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.RequestStatus>(reader.GetString()));

          break;

        case "intent":
          current.IntentElement =new Code<Hl7.Fhir.Model.CarePlan.CarePlanIntent>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.CarePlan.CarePlanIntent>(reader.GetString()));

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

        case "title":
          current.TitleElement = new FhirString(reader.GetString());

          break;

        case "description":
          current.DescriptionElement = new FhirString(reader.GetString());

          break;

        case "subject":
          current.Subject = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "encounter":
          current.Encounter = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "period":
          current.Period = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);

          break;

        case "created":
          current.CreatedElement = new FhirDateTime(reader.GetString());

          break;

        case "author":
          current.Author = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

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

        case "careTeam":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.CareTeam = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.CareTeam.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.CareTeam.Count == 0)
          {
            current.CareTeam = null;
          }

          break;

        case "addresses":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Addresses = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Addresses.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Addresses.Count == 0)
          {
            current.Addresses = null;
          }

          break;

        case "supportingInfo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.SupportingInfo = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.SupportingInfo.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.SupportingInfo.Count == 0)
          {
            current.SupportingInfo = null;
          }

          break;

        case "goal":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Goal = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Goal.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Goal.Count == 0)
          {
            current.Goal = null;
          }

          break;

        case "activity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Activity = new List<CarePlan.ActivityComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Activity.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CarePlan.ActivityComponent>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Activity.Count == 0)
          {
            current.Activity = null;
          }

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

        // Complex: CarePlan, Export: CarePlan, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR CarePlan#Activity into JSON
    /// </summary>
    public static void SerializeJson(this CarePlan.ActivityComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: CarePlan#Activity, Export: ActivityComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.OutcomeCodeableConcept != null) && (current.OutcomeCodeableConcept.Count != 0))
      {
        writer.WritePropertyName("outcomeCodeableConcept");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.OutcomeCodeableConcept)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.OutcomeReference != null) && (current.OutcomeReference.Count != 0))
      {
        writer.WritePropertyName("outcomeReference");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.OutcomeReference)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Progress != null) && (current.Progress.Count != 0))
      {
        writer.WritePropertyName("progress");
        writer.WriteStartArray();
        foreach (Annotation val in current.Progress)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Reference != null)
      {
        writer.WritePropertyName("reference");
        current.Reference.SerializeJson(writer, options);
      }

      if (current.Detail != null)
      {
        writer.WritePropertyName("detail");
        current.Detail.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CarePlan#Activity
    /// </summary>
    public static void DeserializeJson(this CarePlan.ActivityComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR CarePlan#Activity
    /// </summary>
    public static void DeserializeJsonProperty(this CarePlan.ActivityComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "outcomeCodeableConcept":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.OutcomeCodeableConcept = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.OutcomeCodeableConcept.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.OutcomeCodeableConcept.Count == 0)
          {
            current.OutcomeCodeableConcept = null;
          }

          break;

        case "outcomeReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.OutcomeReference = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.OutcomeReference.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.OutcomeReference.Count == 0)
          {
            current.OutcomeReference = null;
          }

          break;

        case "progress":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Progress = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Progress.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.Annotation>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Progress.Count == 0)
          {
            current.Progress = null;
          }

          break;

        case "reference":
          current.Reference = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "detail":
          current.Detail = JsonSerializer.Deserialize<Hl7.Fhir.Model.CarePlan.DetailComponent>(ref reader, options);

          break;

        // Complex: activity, Export: ActivityComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR CarePlan#Detail into JSON
    /// </summary>
    public static void SerializeJson(this CarePlan.DetailComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: CarePlan#Detail, Export: DetailComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.KindElement != null)
      {
        writer.WriteString("kind",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.KindElement.Value));
      }

      if ((current.InstantiatesCanonicalElement != null) && (current.InstantiatesCanonicalElement.Count != 0))
      {
        writer.WritePropertyName("instantiatesCanonical");
        writer.WriteStartArray();
        foreach (Canonical val in current.InstantiatesCanonicalElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if ((current.InstantiatesUriElement != null) && (current.InstantiatesUriElement.Count != 0))
      {
        writer.WritePropertyName("instantiatesUri");
        writer.WriteStartArray();
        foreach (FhirUri val in current.InstantiatesUriElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if (current.Code != null)
      {
        writer.WritePropertyName("code");
        current.Code.SerializeJson(writer, options);
      }

      if ((current.ReasonCode != null) && (current.ReasonCode.Count != 0))
      {
        writer.WritePropertyName("reasonCode");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.ReasonCode)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ReasonReference != null) && (current.ReasonReference.Count != 0))
      {
        writer.WritePropertyName("reasonReference");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.ReasonReference)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Goal != null) && (current.Goal.Count != 0))
      {
        writer.WritePropertyName("goal");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Goal)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      if (current.StatusReason != null)
      {
        writer.WritePropertyName("statusReason");
        current.StatusReason.SerializeJson(writer, options);
      }

      if ((current.DoNotPerformElement != null) && (current.DoNotPerformElement.Value != null))
      {
        writer.WriteBoolean("doNotPerform",(bool)current.DoNotPerformElement.Value);
      }

      if (current.Scheduled != null)
      {
        switch (current.Scheduled)
        {
          case Timing v_Timing:
            writer.WritePropertyName("scheduledTiming");
            v_Timing.SerializeJson(writer, options);
            break;
          case Period v_Period:
            writer.WritePropertyName("scheduledPeriod");
            v_Period.SerializeJson(writer, options);
            break;
          case FhirString v_FhirString:
            writer.WriteString("scheduledString",v_FhirString.Value);
            break;
        }
      }
      if (current.Location != null)
      {
        writer.WritePropertyName("location");
        current.Location.SerializeJson(writer, options);
      }

      if ((current.Performer != null) && (current.Performer.Count != 0))
      {
        writer.WritePropertyName("performer");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Performer)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Product != null)
      {
        switch (current.Product)
        {
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("productCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("productReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if (current.DailyAmount != null)
      {
        writer.WritePropertyName("dailyAmount");
        current.DailyAmount.SerializeJson(writer, options);
      }

      if (current.Quantity != null)
      {
        writer.WritePropertyName("quantity");
        current.Quantity.SerializeJson(writer, options);
      }

      if ((current.DescriptionElement != null) && (current.DescriptionElement.Value != null))
      {
        writer.WriteString("description",current.DescriptionElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CarePlan#Detail
    /// </summary>
    public static void DeserializeJson(this CarePlan.DetailComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR CarePlan#Detail
    /// </summary>
    public static void DeserializeJsonProperty(this CarePlan.DetailComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "kind":
          current.KindElement =new Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityKind>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.CarePlan.CarePlanActivityKind>(reader.GetString()));

          break;

        case "instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.InstantiatesCanonicalElement = new List<Canonical>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.InstantiatesCanonicalElement.Add(new Canonical(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.InstantiatesCanonicalElement.Count == 0)
          {
            current.InstantiatesCanonicalElement = null;
          }

          break;

        case "instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.InstantiatesUriElement = new List<FhirUri>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.InstantiatesUriElement.Add(new FhirUri(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.InstantiatesUriElement.Count == 0)
          {
            current.InstantiatesUriElement = null;
          }

          break;

        case "code":
          current.Code = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ReasonCode.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ReasonCode.Count == 0)
          {
            current.ReasonCode = null;
          }

          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ReasonReference = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ReasonReference.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.ReasonReference.Count == 0)
          {
            current.ReasonReference = null;
          }

          break;

        case "goal":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Goal = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Goal.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Goal.Count == 0)
          {
            current.Goal = null;
          }

          break;

        case "status":
          current.StatusElement =new Code<Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.CarePlan.CarePlanActivityStatus>(reader.GetString()));

          break;

        case "statusReason":
          current.StatusReason = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);

          break;

        case "doNotPerform":
          current.DoNotPerformElement = new FhirBoolean(reader.GetBoolean());

          break;

        case "scheduledTiming":
          current.Scheduled = JsonSerializer.Deserialize<Hl7.Fhir.Model.Timing>(ref reader, options);
          break;

        case "scheduledPeriod":
          current.Scheduled = JsonSerializer.Deserialize<Hl7.Fhir.Model.Period>(ref reader, options);
          break;

        case "scheduledString":
          current.Scheduled = new FhirString(reader.GetString());
          break;

        case "location":
          current.Location = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);

          break;

        case "performer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Performer = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.Performer.Add(JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options));

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (current.Performer.Count == 0)
          {
            current.Performer = null;
          }

          break;

        case "productCodeableConcept":
          current.Product = JsonSerializer.Deserialize<Hl7.Fhir.Model.CodeableConcept>(ref reader, options);
          break;

        case "productReference":
          current.Product = JsonSerializer.Deserialize<Hl7.Fhir.Model.ResourceReference>(ref reader, options);
          break;

        case "dailyAmount":
          current.DailyAmount = JsonSerializer.Deserialize<Hl7.Fhir.Model.Quantity>(ref reader, options);

          break;

        case "quantity":
          current.Quantity = JsonSerializer.Deserialize<Hl7.Fhir.Model.Quantity>(ref reader, options);

          break;

        case "description":
          current.DescriptionElement = new FhirString(reader.GetString());

          break;

        // Complex: detail, Export: DetailComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class CarePlanJsonConverter : JsonConverter<CarePlan>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(CarePlan).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, CarePlan value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override CarePlan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        CarePlan target = new CarePlan();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
