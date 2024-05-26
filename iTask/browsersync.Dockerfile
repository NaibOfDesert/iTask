FROM node:14-alpine

WORKDIR /app

RUN npm install -g browser-sync

ENTRYPOINT ["browser-sync"]