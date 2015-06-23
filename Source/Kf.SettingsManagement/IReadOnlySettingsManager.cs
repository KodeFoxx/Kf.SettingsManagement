﻿namespace Kf.SettingsManagement
{
    /// <summary>
    /// Settings manager that can only read.
    /// </summary>
    public interface IReadOnlySettingsManager
    {
        /// <summary>
        /// Gets a setting by it's key.
        /// </summary>
        /// <param name="key">The setting's key.</param>
        /// <returns>The <see cref="Setting"/>, or null.</returns>
        Setting GetByKey(string key);
    }
}
