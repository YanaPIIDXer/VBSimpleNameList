FROM ruby:2.5.3-alpine

RUN apk update && \
    apk add --no-cache linux-headers libxml2-dev make gcc libc-dev nodejs tzdata mysql-dev mysql yarn && \
    apk add --virtual build-packages --no-cache build-base curl-dev 

WORKDIR /app

COPY ./entrypoint.sh /usr/bin/
RUN chmod +x /usr/bin/entrypoint.sh
ENTRYPOINT ["entrypoint.sh"]

ADD ./src/package.json /app
ADD ./src/yarn.lock /app
RUN yarn install

ADD ./src/Gemfile /app/Gemfile
ADD ./src/Gemfile.lock /app/Gemfile.lock
RUN bundle install

ADD ./src /app

EXPOSE 80
CMD ["rails", "server", "-b", "0.0.0.0", "-p", "80"]
