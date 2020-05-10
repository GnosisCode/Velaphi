const ENV = {
  dev: {
    apiUrl: 'http://localhost:44336',
    oAuthConfig: {
      issuer: 'http://localhost:44336',
      clientId: 'Velaphi_App',
      clientSecret: '1q2w3e*',
      scope: 'Velaphi',
    },
    localization: {
      defaultResourceName: 'Velaphi',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44336',
    oAuthConfig: {
      issuer: 'http://localhost:44336',
      clientId: 'Velaphi_App',
      clientSecret: '1q2w3e*',
      scope: 'Velaphi',
    },
    localization: {
      defaultResourceName: 'Velaphi',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
