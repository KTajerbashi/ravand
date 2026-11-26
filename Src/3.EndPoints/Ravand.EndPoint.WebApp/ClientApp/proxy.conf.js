const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT
  ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}`
  : env.ASPNETCORE_URLS
    ? env.ASPNETCORE_URLS.split(';')[0]
    : 'https://localhost:42500';

const PROXY_CONFIG = [
  {
    // فقط مسیرهایی که باید به سرور دات‌نت بروند
    context: [
      "/api",       // Web API
      "/app",       // Razor Pages
      "/swagger",   // Swagger UI
      "/openapi",   // OpenAPI JSON (خروجی MapOpenApi)
      "/health",    // MapDefaultEndpoints (health checks)
      "/alive"
    ],
    target: target,
    secure: false,          // گواهی توسعه (self-signed) را قبول کند
    changeOrigin: true,
    proxyTimeout: 10000,
    headers: {
      Connection: 'Keep-Alive'
    }
  }
];

module.exports = PROXY_CONFIG;
