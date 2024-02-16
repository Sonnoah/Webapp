﻿using System.Security.Claims;

public static class ClaimsPrincipalExtensions
{
  // public static string? GetUsername(this ClaimsPrincipal user) => user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
  public static string? GetUsername(this ClaimsPrincipal user) => user.FindFirst(ClaimTypes.Name)?.Value;
  public static int? GetUserId(this ClaimsPrincipal user)
  {
    var claim = user.FindFirst(ClaimTypes.NameIdentifier);
    if (claim is not null)
    return int.Parse(claim.Value);
    return null;
  }
}
