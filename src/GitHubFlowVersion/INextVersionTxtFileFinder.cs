﻿namespace GitHubFlowVersion
{
    public interface INextVersionTxtFileFinder
    {
        SemanticVersion GetNextVersion(SemanticVersion taggedVersion);
    }
}