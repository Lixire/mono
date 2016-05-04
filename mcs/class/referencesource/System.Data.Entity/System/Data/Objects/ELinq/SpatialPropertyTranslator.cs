﻿//---------------------------------------------------------------------
// <copyright file="SpatialPropertyTranslator" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//
// @owner       willa
// @backupOwner [....]
//--------------------------------------------------------------------------
// This file is automatically generated and should not be changed directly.
//
// See %SDXROOT%\ndp\fx\test\DataEntity\CheckinTests\Metadata\MetadataUnitTests.sln
// for the spatial functions unit test that generates this file.
//
// See %SDXROOT%\ddsuites\src\fx\DataEntity\Spatial\Functions
// for the template for this file.
//
//--------------------------------------------------------------------------

using System.Collections.Generic;
using System.Data.Common.CommandTrees;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Objects.ELinq
{
    internal sealed partial class ExpressionConverter
    {
        private sealed partial class MemberAccessTranslator
                : TypedTranslator<MemberExpression>
        {
            private sealed class SpatialPropertyTranslator : PropertyTranslator
            {
                private readonly Dictionary<PropertyInfo, string> propertyFunctionRenames = GetRenamedPropertyFunctions();

                internal SpatialPropertyTranslator()
                    : base(GetSupportedProperties())
                {
                }
            
                private static PropertyInfo GetProperty<T, TResult>(Expression<Func<T, TResult>> lambda)
                {
                    MemberExpression memberEx = (MemberExpression)lambda.Body;
                    PropertyInfo property = (PropertyInfo)memberEx.Member;
                    Debug.Assert(property.GetGetMethod().IsPublic &&
                                 !property.GetGetMethod().IsStatic &&
                                 (property.DeclaringType == typeof(System.Data.Spatial.DbGeography) || property.DeclaringType == typeof(System.Data.Spatial.DbGeometry)),
                                 "GetProperty<T, TResult> should only be used to bind to public instance spatial properties");
                    return property;
                }

                private static IEnumerable<PropertyInfo> GetSupportedProperties()
                {
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.CoordinateSystemId);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.SpatialTypeName);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.Dimension);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.IsEmpty);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.ElementCount);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.Latitude);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.Longitude);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.Elevation);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.Measure);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.Length);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.StartPoint);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.EndPoint);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.IsClosed);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.PointCount);
                    yield return GetProperty((System.Data.Spatial.DbGeography geo) => geo.Area);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.CoordinateSystemId);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.SpatialTypeName);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Dimension);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Envelope);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.IsEmpty);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.IsSimple);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Boundary);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.IsValid);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.ConvexHull);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.ElementCount);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.XCoordinate);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.YCoordinate);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Elevation);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Measure);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Length);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.StartPoint);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.EndPoint);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.IsClosed);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.IsRing);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.PointCount);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Area);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Centroid);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.PointOnSurface);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.ExteriorRing);
                    yield return GetProperty((System.Data.Spatial.DbGeometry geo) => geo.InteriorRingCount);
                }

                private static Dictionary<PropertyInfo, string> GetRenamedPropertyFunctions()
                {
                    Dictionary<PropertyInfo, string> result = new Dictionary<PropertyInfo, string>();
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.CoordinateSystemId), "CoordinateSystemId");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.SpatialTypeName), "SpatialTypeName");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.Dimension), "SpatialDimension");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.IsEmpty), "IsEmptySpatial");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.ElementCount), "SpatialElementCount");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.Latitude), "Latitude");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.Longitude), "Longitude");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.Elevation), "Elevation");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.Measure), "Measure");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.Length), "SpatialLength");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.StartPoint), "StartPoint");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.EndPoint), "EndPoint");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.IsClosed), "IsClosedSpatial");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.PointCount), "PointCount");
                    result.Add(GetProperty((System.Data.Spatial.DbGeography geo) => geo.Area), "Area");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.CoordinateSystemId), "CoordinateSystemId");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.SpatialTypeName), "SpatialTypeName");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Dimension), "SpatialDimension");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Envelope), "SpatialEnvelope");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.IsEmpty), "IsEmptySpatial");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.IsSimple), "IsSimpleGeometry");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Boundary), "SpatialBoundary");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.IsValid), "IsValidGeometry");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.ConvexHull), "SpatialConvexHull");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.ElementCount), "SpatialElementCount");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.XCoordinate), "XCoordinate");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.YCoordinate), "YCoordinate");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Elevation), "Elevation");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Measure), "Measure");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Length), "SpatialLength");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.StartPoint), "StartPoint");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.EndPoint), "EndPoint");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.IsClosed), "IsClosedSpatial");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.IsRing), "IsRing");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.PointCount), "PointCount");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Area), "Area");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.Centroid), "Centroid");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.PointOnSurface), "PointOnSurface");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.ExteriorRing), "ExteriorRing");
                    result.Add(GetProperty((System.Data.Spatial.DbGeometry geo) => geo.InteriorRingCount), "InteriorRingCount");
                    return result;
                }

                // Translator for spatial properties into canonical functions. Both static and instance properties are handled.
                // Unless a canonical function name is explicitly specified for a property, the mapping from property name to
                // canonical function name consists simply of applying the 'ST' prefix. Then, translation proceeds as follows:
                //      object.PropertyName  -> CanonicalFunctionName(object)
                //      Type.PropertyName  -> CanonicalFunctionName()
                internal override DbExpression Translate(ExpressionConverter parent, MemberExpression call)
                {
                    PropertyInfo property = (PropertyInfo)call.Member;
                    string canonicalFunctionName;
                    if(!propertyFunctionRenames.TryGetValue(property, out canonicalFunctionName))
                    {
                        canonicalFunctionName = "ST" + property.Name;
                    }

                    Debug.Assert(call.Expression != null, "No static spatial properties currently map to canonical functions");
                    DbExpression result  = parent.TranslateIntoCanonicalFunction(canonicalFunctionName, call, call.Expression);
                    return result;
                }
            }
        }
    }
}
