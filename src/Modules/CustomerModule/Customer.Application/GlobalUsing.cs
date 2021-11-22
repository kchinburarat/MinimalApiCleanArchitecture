﻿global using Agoda.IoC.Core;
global using Customer.Application.Common;
global using Customer.Application.Common.Interfaces;
global using Customer.Application.Features.CreateCustomer.Dto;
global using Customer.Application.Features.CreateCustomer.Exceptions;
global using FluentValidation;
global using Framework.Exceptions.Handlers;
global using FrameworkAgnostic;
global using FrameworkAgnostic.Common.Mappers;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using System.Net;
global using System.Text.Json;
global using ValidationException = SharedKernel.Exceptions.ValidationException;