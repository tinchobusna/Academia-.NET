using DTOs;

namespace BlazorWebAssembly.Services
{
    public class AuthenticationStateService
    {
        public UsuarioDTO? CurrentUser { get; private set; }
        public PersonaDTO? CurrentPersona { get; private set; }
        public bool IsAuthenticated => CurrentUser != null;
        public string? UserRole => CurrentPersona?.TipoPersona;

        public event Action? OnChange;

        public void SetAuthenticationState(UsuarioDTO usuario, PersonaDTO persona)
        {
            CurrentUser = usuario;
            CurrentPersona = persona;
            NotifyStateChanged();
        }

        public void Logout()
        {
            CurrentUser = null;
            CurrentPersona = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
