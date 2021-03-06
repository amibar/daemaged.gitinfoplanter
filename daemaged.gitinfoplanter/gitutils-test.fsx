﻿#I @"..\packages\ngit2.2.1.0.20120927\lib\net40"

#r "NGit.dll"
#r "Sharpen.dll"

open System
open Sharpen
open System
open System.IO
open System.Collections.Generic
open System.Text.RegularExpressions
open System.Reflection;
open Microsoft.FSharp.Text
open System.Reflection

open NGit
open NGit.Api
open NGit.Storage.File
open NGit.Revwalk
open NGit.Treewalk
open NGit.Treewalk.Filter

#load "gitutils.fs"

let repoPath = @"C:\projects\private\daemaged.gitinfoplanter.git\daemaged.gitinfoplanter\obj"


open Daemaged.GitInfoPlanter.gitutils

let r = repoPath |> buildRepo
r.GetBranch()
let tags = r.GetTags()
let t1 = tags.["1.0"]
t1.GetName()
t1.GetObjectId()



r |> getRepoStatus |> modifiedPaths |> filterSubmodules r