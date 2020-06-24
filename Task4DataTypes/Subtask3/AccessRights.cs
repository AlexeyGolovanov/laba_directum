namespace Subtask3
{
    using System;

    /// <summary>
    /// Тип прав.
    /// </summary>
    [Flags, Serializable]
    public enum AccessRights : byte
    {
        /// <summary>
        /// Права на просмотр.
        /// </summary>
        View = 1,

        /// <summary>
        /// Права на выполнение.
        /// </summary>
        Run = 2,

        /// <summary>
        /// Права на добавление.
        /// </summary>
        Add = 4,

        /// <summary>
        /// Права на изменение.
        /// </summary>
        Edit = 8,

        /// <summary>
        /// Права на утверждение.
        /// </summary>
        Ratify = 16,

        /// <summary>
        /// Права на удаление.
        /// </summary>
        Delete = 32,

        /// <summary>
        /// Нет доступа.
        /// </summary>
        /// <remarks>
        /// Этот флаг имеет максимальный приоритет.
        /// Если он установлен, остальные флаги игнорируются 
        /// </remarks>
        AccessDenied = 64
    }
}